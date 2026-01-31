using System.ComponentModel;
using Contracts.DTOs;
using Contracts.Enums;
using Core.Entities;
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
        private readonly IServiceProvider _serviceProvider;

        public MainForm(
            FormFactory formFactory,
            IServiceProvider serviceProvider)
        {
            _formFactory = formFactory;
            _serviceProvider = serviceProvider;

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

        private Settings Settings = new Settings();

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
            //Получаем активные аккаунты c настройками
            IReadOnlyList<Account> activeAccounts = await _formFactory.ShowAccountSetupForm();
            if (activeAccounts.Any() is false)
                return;

            // Запуск сеансов
            if (_cts.IsCancellationRequested)
                _cts = new CancellationTokenSource();

            bool RunningInMultithreadingMode = checkBoxRunningInMultithreadingMode.Checked;

            ReadProfile profile = (ReadProfile)comboBoxReadProfiles.SelectedIndex;

            if (RunningInMultithreadingMode)
            {
                int ConstantDelay = Settings.ConstantDelay;

                int FloatingIncrementalDelay = Settings.FloatingIncrementalDelay;

                Random random = new Random();

                List<Task> tasks = [];
                foreach (Account account in activeAccounts)
                {
                    int FloatingDelay = random.Next(FloatingIncrementalDelay);

                    int Delay = (ConstantDelay + FloatingDelay) * 1000;

                    AppendLog($"Задержка перед запуском: {Delay / 1000}");

                    // Создаем поток с делегатом, который будет выполнять синхронную обертку
                    /*Thread thread = new Thread(() => StartSessionInThread(account, profile, Delay));
                    thread.Start();*/
                    tasks.Add(StartSessionInThread(account, profile, Delay));
                }
                await Task.WhenAll(tasks);
            }
            else
            {
                foreach (Account account in activeAccounts)
                {
                    await StartSession(account, profile);
                }
            }
        }

        private async Task StartSessionInThread(Account account, ReadProfile readProfile, int delay)
        {
            await Task.Delay(delay);
            await StartSession(account, readProfile);
        }

        private async Task StartSession(Account account, ReadProfile readProfile)
        {
            if (_cts.IsCancellationRequested)
                return;

            var links = SplitLinksByDomain(Links);

            string[] litmarketArray = links.litmarketLinks;
            string[] litnetArray = links.litnetLinks;

            if (litnetArray.Length == 0 & litmarketArray.Length == 0)
            {
                AppendLog("[X] URL не указан.");
                return;
            }

            // Создаём сервисы
            await using var scope = _serviceProvider.CreateAsyncScope();
            var serviceLitMarket = scope.ServiceProvider.GetRequiredService<LitMarketService>();
            var serviceLitNet = scope.ServiceProvider.GetRequiredService<LitNetService>();
            
            _activeServicesMarket.Add(serviceLitMarket);
            _activeServices.Add(serviceLitNet);
            
            int litMarketSessionCounter = 0;
            int litNetSessionCounter = 0;

            try
            {
                if (litnetArray.Length != 0)
                {
                    AppendLog("Запуск эмуляции чтения https://litnet.com ...");

                    await serviceLitNet.InitializeAsync();
                    WriteStartSessionToTheReport();
                    litNetSessionCounter++;

                    foreach (var link in litnetArray.Take(3))
                    {
                        await serviceLitNet.Primary_activity(link, AppendLog);
                        _cts.Token.ThrowIfCancellationRequested();
                    }

                    if (await serviceLitNet.Login(account.Login, account.Password, Link_login))
                    {
                        _cts.Token.ThrowIfCancellationRequested();

                        AppendLog($"Выполнен вход в аккаунт {account.Login}");

                        foreach (var link in litnetArray)
                        {
                            int sheetsCount =
                                await serviceLitNet.BaseActivityBot(link, AppendLog, readProfile, Settings);
                            _cts.Token.ThrowIfCancellationRequested();

                            AppendLog($"Выполнено чтение по ссылке {link}");

                            WriteDataToTheReport(new ReportDataDto
                            {
                                User = account.Login,
                                IpAddress = "111",
                                Operation = "Чтение",
                                Book = link,
                                SheetsCount = sheetsCount,
                                Status = nameof(Statuses.Успешно)
                            });
                        }

                        await serviceLitNet.DisposeAsync();
                    }
                    else
                    {
                        AppendLog(
                            $"Неудачная попытка входа в аккаунт. Пользователь: {account.Login}, пароль: {account.Password}");
                        return;
                    }

                    await serviceLitNet.DisposeAsync();
                }
            }
            catch (OperationCanceledException)
            {
                AppendLog("Остановлено пользователем.");
                return;
            }
            catch (PlaywrightException ex)
            {
                // Проверяем по сообщению
                if (ex.Message.Contains("Target closed") ||
                    ex.Message.Contains("closed") ||
                    ex.Message.Contains("Session closed"))
                {
                    AppendLog($"Браузер был закрыт.");
                    return;
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                AppendLog($"[X] Ошибка: {ex.Message}");
                return;
            }
            finally
            {
                _activeServices.Remove(serviceLitNet);
                await serviceLitNet.DisposeAsync();

                if (litNetSessionCounter > 0)
                    WriteEndSessionToTheReport();
            }

            try
            {
                if (litmarketArray.Length != 0)
                {
                    AppendLog("Запуск эмуляции чтения https://litmarket.ru/ ...");

                    await serviceLitMarket.InitializeAsync();
                    WriteStartSessionToTheReport();
                    litMarketSessionCounter++;

                    if (await serviceLitMarket.Login(account.Login, account.Password, "https://litmarket.ru/",
                            AppendLog))
                    {
                        _cts.Token.ThrowIfCancellationRequested();

                        AppendLog($"Выполнен вход в аккаунт {account.Login}");

                        foreach (string link in litmarketArray)
                        {
                            int sheetsCount =
                                await serviceLitMarket.Reader_books(link, AppendLog, readProfile, Settings);
                            _cts.Token.ThrowIfCancellationRequested();

                            AppendLog($"Выполнено чтение по ссылке {link}");

                            WriteDataToTheReport(new ReportDataDto
                            {
                                User = account.Login,
                                IpAddress = "111",
                                Operation = "Чтение",
                                Book = link,
                                SheetsCount = sheetsCount,
                                Status = nameof(Statuses.Успешно)
                            });
                        }

                        await serviceLitMarket.DisposeAsync();
                    }
                    else
                    {
                        AppendLog(
                            $"Неудачная попытка входа в аккаунт. Пользователь: {account.Login}, пароль: {account.Password}");
                        return;
                    }

                    await serviceLitMarket.DisposeAsync();
                    _cts.Token.ThrowIfCancellationRequested();
                }
            }
            catch (OperationCanceledException)
            {
                AppendLog("Остановлено пользователем.");
                return;
            }
            catch (PlaywrightException ex)
            {
                // Проверяем по сообщению
                if (ex.Message.Contains("Target closed") ||
                    ex.Message.Contains("closed") ||
                    ex.Message.Contains("Session closed"))
                {
                    AppendLog($"Браузер был закрыт.");
                    return;
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                AppendLog($"[X] Ошибка: {ex.Message}");
                return;
            }
            finally
            {
                _activeServicesMarket.Remove(serviceLitMarket);
                await serviceLitMarket.DisposeAsync();

                if (litMarketSessionCounter > 0)
                    WriteEndSessionToTheReport();
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

            Settings.ReadProfile = (ReadProfile)comboBoxReadProfiles.SelectedIndex;

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
            checkBoxReadBook.Checked = Settings.ReadBook;

            checkBoxAddToLibrary.Checked = Settings.AddToLibrary;

            checkBoxLikeTheBook.Checked = Settings.LikeTheBook;

            checkBoxSubscribeToTheAuthor.Checked = Settings.SubscribeToTheAuthor;

            checkBoxPostComment.Checked = Settings.PostComment;

            checkBoxMakeADonationToTheAuthor.Checked = Settings.MakeADonationToTheAuthor;

            checkBoxBuyABook.Checked = Settings.BuyABook;

            numericUpDownConstantDelay.Value = Settings.ConstantDelay;

            numericUpDownFloatingIncrementalDelay.Value = Settings.FloatingIncrementalDelay;

            comboBoxReadProfiles.SelectedIndex = (int)Settings.ReadProfile;
        }

        private void SaveSettings()
        {
            if (!_settingsAreLoaded)
            {
                return;
            }

            Settings.ReadBook = checkBoxReadBook.Checked;

            Settings.AddToLibrary = checkBoxAddToLibrary.Checked;

            Settings.LikeTheBook = checkBoxLikeTheBook.Checked;

            Settings.SubscribeToTheAuthor = checkBoxSubscribeToTheAuthor.Checked;

            Settings.PostComment = checkBoxPostComment.Checked;

            Settings.MakeADonationToTheAuthor = checkBoxMakeADonationToTheAuthor.Checked;

            Settings.BuyABook = checkBoxBuyABook.Checked;

            Settings.ConstantDelay = (int)numericUpDownConstantDelay.Value;

            Settings.FloatingIncrementalDelay = (int)numericUpDownFloatingIncrementalDelay.Value;

            // Сохранение настроек профилей
            for (int i = 0; i < comboBoxReadProfiles.Items.Count; i++)
            {
                ReadProfile readReadProfile = (ReadProfile)i;

                if (!Settings.ReadProfileSettings.ContainsKey(readReadProfile))
                {
                    // Ключа нет - добавляем новую пару
                    Settings.ReadProfileSettings.Add(readReadProfile,
                        SettingsManager.CreateDefaultReadProfileSettings(readReadProfile));
                }
            }

            SaveParameters();
        }

        #endregion

        #region Service_Methods

        private void SetParameters()
        {
            Settings = SettingsManager.Load();

            comboBoxReadProfiles.SelectedIndex = (int)Settings.ReadProfile;
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
            SettingsManager.Save(Settings);
        }

        public void SaveData()
        {
            AccountsManager.Save(Accounts);
            LinksManager.Save(Links);
        }

        public async Task StopAllServicesAsync()
        {
            // Отменяем выполнение
            _cts?.Cancel();

            // Останавливаем все сервисы
            var tasks = _activeServices.Select(async service =>
            {
                try
                {
                    await service.DisposeAsync();
                }
                catch (Exception ex)
                {
                    AppendLog($"Ошибка при остановке сервиса: {ex.Message}");
                }
            }).ToList();

            var tasksMarket = _activeServicesMarket.Select(async service =>
            {
                try
                {
                    await service.DisposeAsync();
                }
                catch (Exception ex)
                {
                    AppendLog($"Ошибка при остановке сервиса: {ex.Message}");
                }
            }).ToList();

            await Task.WhenAll(tasks);
            await Task.WhenAll(tasksMarket);
            _activeServices.Clear();
        }

        #endregion

        #region Reports

        private enum Statuses
        {
            Успешно,
            Неудачно
        }

        private void WriteStartSessionToTheReport()
        {
            ReportDataDto reportDataDto = new ReportDataDto
            {
                Operation = "Начало сессии",
                SessionDateTime = DateTime.Now
            };

            _reportDataBindingList.Add(reportDataDto);
        }

        private void WriteEndSessionToTheReport()
        {
            ReportDataDto reportDataDto = new ReportDataDto
            {
                Operation = "Конец сессии",
                SessionDateTime = DateTime.Now
            };

            _reportDataBindingList.Add(reportDataDto);
        }

        private void WriteDataToTheReport(ReportDataDto reportData)
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