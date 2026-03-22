using System.ComponentModel;
using Contracts.DTOs;
using Core.Entities;
using Core.Handlers;
using Core.Services;
using LitPulse.FileProviders;
using LitPulse.Data;
using LitPulse.Factory;

namespace LitPulse.Forms
{
    public partial class MainForm : Form
    {
        private readonly FormFactory _formFactory;
        private readonly StartSingleThreadHandler _startSingleThreadHandler;
        private readonly StartMultithreadHandler _startMultithreadHandler;
        private readonly StartBatchMultithreadHandler _startBatchMultithreadHandler;
        private readonly ReportService _reportService;

        private CancellationTokenSource _cts;

        public MainForm(
            FormFactory formFactory,
            StartSingleThreadHandler startSingleThreadHandler,
            StartMultithreadHandler startMultithreadHandler,
            StartBatchMultithreadHandler startBatchMultithreadHandler,
            ReportService reportService)
        {
            _formFactory = formFactory;
            _startSingleThreadHandler = startSingleThreadHandler;
            _startMultithreadHandler = startMultithreadHandler;
            _startBatchMultithreadHandler = startBatchMultithreadHandler;
            _reportService = reportService;
            _cts = new CancellationTokenSource();

            InitializeComponent();
            LoadData();

            dataGridViewReport.DataSource = _reportDataBindingList;

            _reportService.ReportItemAdded += OnReportItemAdded;
        }

        #region Litnet_LitMarket_Parameters

        private BindingList<Data.Links> _links = new BindingList<Data.Links>();

        private BindingList<ReportDataDto> _reportDataBindingList = new();

        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private async void buttonStartSession_Click(object sender, EventArgs e)
        {
            await StartSessionAsync();
        }

        private async Task StartSessionAsync()
        {
            //Получаем активные аккаунты c настройками
            IReadOnlyList<Account> activeAccounts = await _formFactory.ShowAccountSetupForm();

            LoadData();

            if (activeAccounts.Any() is false)
                return;

            // Запуск сеансов
            if (_cts.IsCancellationRequested)
                _cts = new CancellationTokenSource();

            var links = SplitLinksByDomain(_links);

            bool runningInMultithreadingMode = checkBoxRunningInMultithreadingMode.Checked;

            if (runningInMultithreadingMode)
            {
                int constantDelay = (int)numericUpDownConstantDelay.Value;
                int floatingIncrementalDelay = (int)numericUpDownFloatingIncrementalDelay.Value;
                int multithreadAccountsCount = (int)numericUpDownAccountCount.Value;

                if (checkBoxBatchLaunch.Checked)
                {
                    await _startBatchMultithreadHandler.HandleAsync(
                        activeAccounts,
                        multithreadAccountsCount,
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
                        multithreadAccountsCount,
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

        #region Links

        private void buttonImportLinks_Click(object sender, EventArgs e)
        {
            string[] links = TxtFileInList();

            AddLinks(links);

            SaveData();
        }

        private void buttonAddLink_Click(object sender, EventArgs e)
        {
            _links.Add(new Data.Links(""));

            SaveData();
        }

        private void buttonDeleteLink_Click(object sender, EventArgs e)
        {
            if (dataGridViewLinks.CurrentRow != null && dataGridViewLinks.CurrentRow.DataBoundItem is Data.Links link)
            {
                _links.Remove(link);

                SaveData();
            }
        }

        private void buttonClearLinks_Click(object sender, EventArgs e)
        {
            _links.Clear();

            SaveData();
        }

        private void dataGridViewLinks_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
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

        private void checkBoxRunningInMultithreadingMode_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBatchLaunch.Enabled = checkBoxRunningInMultithreadingMode.Checked;
        }

        #endregion

        #region Service_Methods

        private void LoadData()
        {
            _links = LinksManager.Load();
            dataGridViewLinks.DataSource = _links;
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

                _links.Add(new Data.Links(line));
            }
        }

        public static (List<Core.Entities.Links> litmarketLinks, List<Core.Entities.Links> litnetLinks) SplitLinksByDomain(BindingList<Data.Links> links)
        {
            List<Core.Entities.Links> litmarket = new List<Core.Entities.Links>();
            List<Core.Entities.Links> litnet = new List<Core.Entities.Links>();

            foreach (Data.Links link in links)
            {
                if (link.Link.StartsWith("https://litmarket.ru/"))
                    litmarket.Add(new Core.Entities.Links(link.Link, link.AccountsId));
                else if (link.Link.StartsWith("https://litnet.com"))
                    litnet.Add(new Core.Entities.Links(link.Link, link.AccountsId));
            }

            return (litmarket, litnet);
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

        public void SaveData()
        {
            LinksManager.Save(_links);
        }

        private async Task StopAllServicesAsync()
        {
            // Отменяем выполнение при помощи токена отмены
            await _cts.CancelAsync();

            // Пересоздаём токен
            _cts = new CancellationTokenSource();
        }

        #endregion

        #region Reports

        public void WriteDataToTheReport(ReportDataDto reportData)
        {
            _reportDataBindingList.Add(reportData);
        }

        private void OnReportItemAdded(object sender, ReportDataDto item)
        {
            if (InvokeRequired)
            {
                Invoke(() => OnReportItemAdded(sender, item));
                return;
            }

            _reportDataBindingList.Add(item);
        }

        private async void buttonSaveReport_Click(object sender, EventArgs e)
        {
            await SaveDataToTheReportAsync();
        }

        private async Task SaveDataToTheReportAsync()
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
                        SessionId = Guid.TryParse(row.Cells["SessionId"].Value?.ToString(), out var sessionId)
                            ? sessionId
                            : Guid.Empty,
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

                ReportExcelProvider reportExcelProvider = new ReportExcelProvider();
                await reportExcelProvider.SaveFileAsync(reportDataList, _cts.Token);
            }
        }

        #endregion

        #region Proxys
        private void buttonProxySettings_Click(object sender, EventArgs e)
        {
            ProxySettingsForm proxySettingsForm = new ProxySettingsForm();
            proxySettingsForm.Show();
        }

        #endregion

    }
}