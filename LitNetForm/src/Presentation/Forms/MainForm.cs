using System.ComponentModel;
using Contracts.DTOs;
using Contracts.Enums;
using Core.Abstracts;
using Core.Entities;
using Core.Handlers;
using Core.Manager;
using Core.Services;
using Core.Settings;
using LitPulse.FileProviders;
using Microsoft.Playwright;
using LitPulse.Data;
using LitPulse.Factory;
using Microsoft.Extensions.DependencyInjection;

namespace LitPulse.Forms
{
    public partial class MainForm : Form
    {
        private readonly bool _settingsAreLoaded;

        private readonly FormFactory _formFactory;
        private readonly StartSingleThreadHandler _startSingleThreadHandler;
        private readonly StartMultithreadHandler _startMultithreadHandler;
        private readonly StartBatchMultithreadHandler _startBatchMultithreadHandler;
        private readonly ServiceManager _serviceManager;

        public MainForm(
            FormFactory formFactory,
            StartSingleThreadHandler startSingleThreadHandler,
            StartMultithreadHandler startMultithreadHandler,
            StartBatchMultithreadHandler startBatchMultithreadHandler,
            ServiceManager serviceManager)
        {
            _formFactory = formFactory;
            _startSingleThreadHandler = startSingleThreadHandler;
            _startMultithreadHandler = startMultithreadHandler;
            _startBatchMultithreadHandler = startBatchMultithreadHandler;
            _serviceManager = serviceManager;

            InitializeComponent();
            SetParameters();
            LoadSettings();
            LoadData();

            _settingsAreLoaded = true;

            dataGridViewAccounts.DataSource = Accounts;
            dataGridViewLinks.DataSource = Links;
            dataGridViewReport.DataSource = _reportDataBindingList;
        }

        #region Litnet_LitMarket_Parameters

        private StartupSettings _startupSettings = new StartupSettings();

        private static string Link_login =
            "https://litnet.com/auth/login?classic=1&link=https%3A%2F%2Flitnet.com%2Fru%2Fbook%2Fvozmu-tebya-b531445";

        private string[] ProfileDescription =
        {
            "Минимум пауз, почти без возвратов. Подходит для ознакомительного чтения или поиска ключевых моментов. Как человек, который «пробегает глазами».",
            "Читает медленно, часто возвращается к предыдущим абзацам, делает длинные паузы. Имитирует внимательного, сосредоточенного читателя — как при изучении сложного текста.",
            "Начинает бодро, но постепенно замедляется, дольше думает, чаще «теряет концентрацию» (доп. паузы в середине и ближе к концу). Реалистично для вечернего чтения."
        };

        private BindingList<Links> Links = new BindingList<Links>();

        // Старый список аккаунтов
        private BindingList<Accounts> Accounts = new BindingList<Accounts>();

        private BindingList<ReportDataDto> _reportDataBindingList = new();

        // Новый список аккаунтов (доделать и в сеансах использовать его)
        //private List<Account> accounts = new List<Account>();

        #endregion

        private readonly List<LitNetService> _activeServices = [];
        private readonly List<LitMarketService> _activeServicesMarket = [];
        private CancellationTokenSource _cts = new();

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveParameters();
            SaveData();
        }

        private async void buttonStartSession_Click(object sender, EventArgs e)
        {
            await StartSessionAsync(_cts.Token);
        }

        private async Task StartSessionAsync(CancellationToken cancellationToken)
        {
            //Получаем активные аккаунты c настройками
            IReadOnlyList<Account> activeAccounts = await _formFactory.ShowAccountSetupForm();
            if (activeAccounts.Any() is false)
                return;

            // Запуск сеансов
            if (_cts.IsCancellationRequested)
                _cts = new CancellationTokenSource();

            var links = SplitLinksByDomain(Links);

            bool runningInMultithreadingMode = checkBoxRunningInMultithreadingMode.Checked;
            
            if (runningInMultithreadingMode)
            {
                int constantDelay = _startupSettings.ConstantDelay;
                int floatingIncrementalDelay = _startupSettings.FloatingIncrementalDelay;
                int accountsCount = (int)numericUpDownAccountCount.Value;

                if (checkBoxBatchLaunch.Checked)
                {
                    await _startBatchMultithreadHandler.HandleAsync(
                        activeAccounts,
                        accountsCount,
                        links.litnetLinks,
                        links.litmarketLinks,
                        new DelayDto(constantDelay, floatingIncrementalDelay),
                        AppendLog,
                        _cts.Token);
                }
                else
                {
                    await _startMultithreadHandler.HandleAsync(
                        activeAccounts,
                        accountsCount,
                        links.litnetLinks,
                        links.litmarketLinks,
                        new DelayDto(constantDelay, floatingIncrementalDelay),
                        AppendLog,
                        _cts.Token);
                }
            }
            else
            {
                await _startSingleThreadHandler.HandleAsync(
                    activeAccounts,
                    links.litnetLinks,
                    links.litmarketLinks,
                    AppendLog,
                    _cts.Token);
            }   
        }

        private async void buttonStop_Click(object sender, EventArgs e)
        {
            await StopAllServicesAsync();
        }

        private void button_instruction_Click(object sender, EventArgs e)
        {
            InstructionForm instructionForm = new InstructionForm();
            instructionForm.Show();
        }

        private void buttonAccountGenerator_Click(object sender, EventArgs e)
        {
        }

        #region Accounts

        private void buttonImportAccounts_Click(object sender, EventArgs e)
        {
            string[] accounts = TxtFileInList();

            AddAccounts(accounts);

            SaveData();
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            Accounts.Add(new Accounts("", ""));

            SaveData();
        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            if (dataGridViewAccounts.CurrentRow != null &&
                dataGridViewAccounts.CurrentRow.DataBoundItem is Accounts account)
            {
                Accounts.Remove(account);

                SaveData();
            }
        }

        private void buttonClearAccounts_Click(object sender, EventArgs e)
        {
            Accounts.Clear();

            SaveData();
        }

        #endregion

        #region Links

        private void buttonImportLinks_Click(object sender, EventArgs e)
        {
            string[] links = TxtFileInList();

            AddLinks(links);

            SaveData();
        }

        private void buttonAddLink_Click(object sender, EventArgs e)
        {
            Links.Add(new Links(""));

            SaveData();
        }

        private void buttonDeleteLink_Click(object sender, EventArgs e)
        {
            if (dataGridViewLinks.CurrentRow != null && dataGridViewLinks.CurrentRow.DataBoundItem is Links link)
            {
                Links.Remove(link);

                SaveData();
            }
        }

        private void buttonClearLinks_Click(object sender, EventArgs e)
        {
            Links.Clear();

            SaveData();
        }

        #endregion

        #region Logs

        private void buttonUploadLogs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Сохранить логи в файл";
            saveFileDialog1.DefaultExt = "txt";

            // Предлагаем имя файла с датой
            saveFileDialog1.FileName = $"logs_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Сохраняем текст из RichTextBox
                    File.WriteAllText(saveFileDialog1.FileName, richTextBoxLog.Text);
                    MessageBox.Show($"Логи сохранены в файл:\n{saveFileDialog1.FileName}",
                        "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении:\n{ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Settings

        private void comboBoxReadProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxProfile.Text = ProfileDescription[comboBoxReadProfiles.SelectedIndex];

            _startupSettings.ReadProfile = (ReadProfile)comboBoxReadProfiles.SelectedIndex;

            SaveParameters();
        }

        private void checkBoxReadBook_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void checkBoxLikeTheBook_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void checkBoxAddToLibrary_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void checkBoxSubscribeToTheAuthor_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void checkBoxPostComment_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void checkBoxMakeADonationToTheAuthor_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void checkBoxBuyABook_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void numericUpDownConstantDelay_ValueChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void numericUpDownFloatingIncrementalDelay_ValueChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void LoadSettings()
        {
            checkBoxReadBook.Checked = _startupSettings.ReadBook;

            checkBoxAddToLibrary.Checked = _startupSettings.AddToLibrary;

            checkBoxLikeTheBook.Checked = _startupSettings.LikeTheBook;

            checkBoxSubscribeToTheAuthor.Checked = _startupSettings.SubscribeToTheAuthor;

            checkBoxPostComment.Checked = _startupSettings.PostComment;

            checkBoxMakeADonationToTheAuthor.Checked = _startupSettings.MakeADonationToTheAuthor;

            checkBoxBuyABook.Checked = _startupSettings.BuyABook;

            numericUpDownConstantDelay.Value = _startupSettings.ConstantDelay;

            numericUpDownFloatingIncrementalDelay.Value = _startupSettings.FloatingIncrementalDelay;

            comboBoxReadProfiles.SelectedIndex = (int)_startupSettings.ReadProfile;
        }

        private void SaveSettings()
        {
            if (!_settingsAreLoaded)
            {
                return;
            }

            _startupSettings.ReadBook = checkBoxReadBook.Checked;

            _startupSettings.AddToLibrary = checkBoxAddToLibrary.Checked;

            _startupSettings.LikeTheBook = checkBoxLikeTheBook.Checked;

            _startupSettings.SubscribeToTheAuthor = checkBoxSubscribeToTheAuthor.Checked;

            _startupSettings.PostComment = checkBoxPostComment.Checked;

            _startupSettings.MakeADonationToTheAuthor = checkBoxMakeADonationToTheAuthor.Checked;

            _startupSettings.BuyABook = checkBoxBuyABook.Checked;

            _startupSettings.ConstantDelay = (int)numericUpDownConstantDelay.Value;

            _startupSettings.FloatingIncrementalDelay = (int)numericUpDownFloatingIncrementalDelay.Value;

            // Сохранение настроек профилей
            for (int i = 0; i < comboBoxReadProfiles.Items.Count; i++)
            {
                ReadProfile readReadProfile = (ReadProfile)i;

                if (!_startupSettings.ReadProfileSettings.ContainsKey(readReadProfile))
                {
                    // Ключа нет - добавляем новую пару
                    _startupSettings.ReadProfileSettings.Add(readReadProfile,
                        SettingsManager.CreateDefaultReadProfileSettings(readReadProfile));
                }
            }

            SaveParameters();
        }
        
        private void checkBoxRunningInMultithreadingMode_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBatchLaunch.Enabled = checkBoxRunningInMultithreadingMode.Checked;
        }

        #endregion

        #region Service_Methods

        private void SetParameters()
        {
            _startupSettings = SettingsManager.Load();

            comboBoxReadProfiles.SelectedIndex = (int)_startupSettings.ReadProfile;
        }

        private void LoadData()
        {
            Accounts = AccountsManager.Load();

            Links = LinksManager.Load();
        }

        private string[] TxtFileInList()
        {
            openFileDialog1.Title = "Выберите текстовый файл";
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            // Если пользователь выбрал файл и нажал OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Читаем все строки из файла в массив
                    return File.ReadAllLines(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла:\n{ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return Array.Empty<string>();
                }
            }
            else
            {
                return Array.Empty<string>();
            }
        }

        public void AddAccounts(string[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0)
                return;

            foreach (string line in inputArray)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                // Разделяем строку по двоеточию
                string[] parts = line.Split(':', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 2)
                {
                    string login = parts[0].Trim();
                    string password = parts[1].Trim();

                    Accounts.Add(new Accounts(login, password));
                }
                else if (parts.Length > 2)
                {
                    // Если в пароле есть двоеточие, обрабатываем особым образом
                    string login = parts[0].Trim();
                    string password = string.Join(":", parts.Skip(1)).Trim();

                    Accounts.Add(new Accounts(login, password));
                }
                // Игнорируем строки с неверным форматом
            }
        }

        public void AddLinks(string[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0)
                return;

            foreach (string line in inputArray)
            {
                if (string.IsNullOrWhiteSpace(line)
                    || (!line.StartsWith("https://litnet.com/ru/book/") &
                        !line.StartsWith("https://litmarket.ru/books/")))
                    continue;

                Links.Add(new Links(line));
            }
        }

        public static (string[] litmarketLinks, string[] litnetLinks) SplitLinksByDomain(BindingList<Links> links)
        {
            List<string> litmarket = new List<string>();
            List<string> litnet = new List<string>();

            foreach (Links link in links)
            {
                if (link.Link.StartsWith("https://litmarket.ru/"))
                    litmarket.Add(link.Link);
                else if (link.Link.StartsWith("https://litnet.com"))
                    litnet.Add(link.Link);
            }

            return (litmarket.ToArray(), litnet.ToArray());
        }

        public void AppendLog(string message)
        {
            if (richTextBoxLog?.InvokeRequired == true)
            {
                richTextBoxLog.Invoke(new Action(() => AppendLog(message)));
            }
            else
            {
                string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
                richTextBoxLog?.AppendText($"[{timestamp}] {message}\n");
                richTextBoxLog?.ScrollToCaret();
            }
        }

        public void SaveParameters()
        {
            SettingsManager.Save(_startupSettings);
        }

        public void SaveData()
        {
            AccountsManager.Save(Accounts);
            LinksManager.Save(Links);
        }

        private async Task StopAllServicesAsync()
        {
            // Отменяем выполнение
            await _cts?.CancelAsync();
            await _serviceManager.CompleteServices();
        }

        #endregion

        #region Reports

        public void WriteDataToTheReport(ReportDataDto reportData)
        {
            _reportDataBindingList.Add(reportData);
        }

        private async void buttonSaveReport_Click(object sender, EventArgs e)
        {
            await SaveDataToTheReportAsync(_cts.Token);
        }

        private async Task SaveDataToTheReportAsync(CancellationToken cancellationToken)
        {
            if (dataGridViewReport.Rows.Count > 0)
            {
                List<ReportDataDto> reportDataList = [];
                foreach (DataGridViewRow row in dataGridViewReport.Rows)
                {
                    if (row.IsNewRow) continue;

                    reportDataList.Add(new ReportDataDto
                    {
                        User = row.Cells["User"].Value?.ToString() ?? string.Empty,
                        IpAddress = row.Cells["UserIpAddress"].Value?.ToString() ?? string.Empty,
                        Operation = row.Cells["Operation"].Value?.ToString() ?? string.Empty,
                        Book = row.Cells["Book"].Value?.ToString() ?? string.Empty,
                        SheetsCount = int.TryParse(row.Cells["SheetsCount"].Value?.ToString(), out var count)
                            ? (count == 0 ? null : count)
                            : null,
                        Status = row.Cells["Status"].Value?.ToString() ?? string.Empty,
                        SessionDateTime =
                            DateTime.TryParse(row.Cells["SessionDateTime"].Value?.ToString(), out var date)
                                ? date
                                : null
                    });
                }

                ReportExcelProvider reportExcelProvider = new ReportExcelProvider(reportDataList);
                await reportExcelProvider.SaveFileAsync(cancellationToken);
            }
        }

        #endregion
    }
}