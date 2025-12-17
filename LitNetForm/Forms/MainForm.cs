using Lit_net_bot_test;
using LitNetForm.Data;
using LitNetForm.Settings;
using LitPulse.Forms;
using Microsoft.Playwright;
using net_market_bot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LitNetForm.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            SetParameters();

            LoadData();

            dataGridViewAccounts.DataSource = Accounts;
            dataGridViewLinks.DataSource = Links;
        }

        #region Litnet_LitMarket_Parameters

        private Settings.Settings Settings = new Settings.Settings();

        private static string Link_login = "https://litnet.com/auth/login?classic=1&link=https%3A%2F%2Flitnet.com%2Fru%2Fbook%2Fvozmu-tebya-b531445";

        private string[] ProfileDescription = {
            "Минимум пауз, почти без возвратов. Подходит для ознакомительного чтения или поиска ключевых моментов. Как человек, который «пробегает глазами».",
            "Читает медленно, часто возвращается к предыдущим абзацам, делает длинные паузы. Имитирует внимательного, сосредоточенного читателя — как при изучении сложного текста.",
            "Начинает бодро, но постепенно замедляется, дольше думает, чаще «теряет концентрацию» (доп. паузы в середине и ближе к концу). Реалистично для вечернего чтения." };

        private BindingList<Links> Links = new BindingList<Links>();

        private BindingList<Accounts> Accounts = new BindingList<Accounts>();

        #endregion

        private List<PlaywrightService_for_litnet> _activeServices = new();
        private List<Lit_market> _activeServicesMarket = new();
        private CancellationTokenSource _cts = new();

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveParameters();
            SaveData();
        }

        private async void buttonStartSession_Click(object sender, EventArgs e)
        {

            var links = SplitLinksByDomain(Links);

            string[] litmarketArray = links.litmarketLinks;
            string[] litnetArray = links.litnetLinks;

            Scroll_model.Profile profile = (Scroll_model.Profile)comboBoxReadProfiles.SelectedIndex;

            if (litnetArray.Length == 0 & litmarketArray.Length == 0)
            {
                AppendLog("[X] URL не указан.");
                return;
            }

            _cts = new CancellationTokenSource();

            foreach (Accounts account in Accounts)
            {
                // Litnet
                var serviceLitNet = new PlaywrightService_for_litnet();
                _activeServices.Add(serviceLitNet);

                try
                {
                    if (litnetArray.Length != 0)
                    {
                        AppendLog("Запуск эмуляции чтения https://litnet.com ...");

                        await serviceLitNet.InitializeAsync();
                        foreach (var link in litnetArray.Take(3))
                        {
                            await serviceLitNet.Primary_activity(link, AppendLog);
                            _cts.Token.ThrowIfCancellationRequested();
                        }

                        await serviceLitNet.Login(account.Login, account.Password, Link_login);
                        _cts.Token.ThrowIfCancellationRequested();

                        AppendLog($"Выполнен вход в аккаунт {account.Login}");

                        foreach (var link in litnetArray)
                        {
                            await serviceLitNet.Base_Activuty_bot(link, AppendLog, profile, Settings);
                            _cts.Token.ThrowIfCancellationRequested();

                            AppendLog($"Выполнено чтение по ссылке {link}");

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
                }

                // Litmarket
                var serviceLitMarket = new Lit_market();
                _activeServicesMarket.Add(serviceLitMarket);

                try
                {
                    if (litmarketArray.Length != 0)
                    {
                        AppendLog("Запуск эмуляции чтения https://litmarket.ru/ ...");

                        await serviceLitMarket.InitializeAsync();
                        await serviceLitMarket.Login(account.Login, account.Password, "https://litmarket.ru/", AppendLog);
                        _cts.Token.ThrowIfCancellationRequested();

                        AppendLog($"Выполнен вход в аккаунт {account.Login}");

                        foreach (string link in litmarketArray)
                        {
                            await serviceLitMarket.Reader_books(link, AppendLog, profile, Settings);
                            _cts.Token.ThrowIfCancellationRequested();

                            AppendLog($"Выполнено чтение по ссылке {link}");

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
                    await serviceLitNet.DisposeAsync();
                }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopAllServicesAsync();
        }
        
        private void button_instruction_Click(object sender, EventArgs e)
        {
            InstructionForm instructionForm = new InstructionForm();
            instructionForm.Show();
        }

        #region Settings

        private void comboBoxReadProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxProfile.Text = ProfileDescription[comboBoxReadProfiles.SelectedIndex];

            Settings.ReadProfile = (Scroll_model.Profile)comboBoxReadProfiles.SelectedIndex;

            SaveParameters();
        }

        private void buttonOtherSettings_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new SettingsForm(Settings))
            {
                // Открываем форму как диалог
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    // Получаем настройки
                    Settings = settingsForm.Settings;

                    SaveParameters();
                }
            }
        }

        #endregion

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
            if (dataGridViewAccounts.CurrentRow != null && dataGridViewAccounts.CurrentRow.DataBoundItem is Accounts account)
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
                || (!line.StartsWith("https://litnet.com/ru/book/") & !line.StartsWith("https://litmarket.ru/books/")))
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
            _activeServices.Clear();
        }

        #endregion

    }
}
