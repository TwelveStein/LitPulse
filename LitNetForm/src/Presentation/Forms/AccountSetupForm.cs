using Contracts.DTOs;
using Core.Entities;
using Core.Entities.ValueObjects;
using Core.Enums;
using Core.Services;
using LitPulse.Data;
using LitPulse.Processors;
using System.ComponentModel;
using System.Windows.Forms;

namespace LitPulse.Forms
{
    public partial class AccountSetupForm : Form
    {
        private readonly AccountsService _accountsService;

        private readonly BindingList<AccountDto> _activeAccountsDataBindingList = [];
        private readonly BindingList<AccountDto> _inactiveAccountsDataBindingList = [];

        private BindingList<Data.Links> _links = new BindingList<Data.Links>();

        private readonly CancellationToken _cancellationToken;

        private IReadOnlyList<Account> _accounts = [];

        public AccountSetupForm(AccountsService accountsService)
        {
            InitializeComponent();

            _cancellationToken = new CancellationTokenSource().Token;

            _accountsService = accountsService;

            dataGridViewActiveAccounts.DataSource = _activeAccountsDataBindingList;
            dataGridViewInactiveAccounts.DataSource = _inactiveAccountsDataBindingList;

            _activeAccountsDataBindingList.ListChanged += ItemIsChanged!;

            LoadData();
        }

        #region Data

        private void LoadData()
        {
            _links = LinksManager.Load();

            dataGridViewLinks.DataSource = _links;
        }

        public void SaveData()
        {
            LinksManager.Save(_links);
        }

        #endregion

        private void ItemIsChanged(object sender, ListChangedEventArgs args)
        {
            if (args.ListChangedType != ListChangedType.ItemChanged)
                return;

            var list = (BindingList<AccountDto>)sender;

            if (args.NewIndex < 0 || args.NewIndex >= list.Count)
                return;

            AccountDto accountDto = list[args.NewIndex];

            UpdateMainInfo(accountDto);
        }

        private async void AccountSetupForm_Load(object sender, EventArgs e)
        {
            await FillAccountsDataOnFormAsync(_cancellationToken);
        }

        private async Task GetAccountsDataFromDatabaseAsync(CancellationToken cancellationToken)
        {
            _accounts = await _accountsService.GetAllAccountsWithSettingsAsync(cancellationToken);
        }

        /// <summary>
        /// Загружает аккаунты в dataGridView
        /// </summary>
        private async Task FillAccountsDataOnFormAsync(CancellationToken cancellationToken)
        {
            await GetAccountsDataFromDatabaseAsync(cancellationToken);

            _activeAccountsDataBindingList.Clear();
            _inactiveAccountsDataBindingList.Clear();

            foreach (var account in _accounts)
            {
                AccountDto accountDto = new AccountDto(
                    account.Login,
                    account.Password,
                    account.LitNet,
                    account.LitMarket)
                {
                    Id = account.Id
                };

                if (account.IsActive)
                {
                    _activeAccountsDataBindingList.Add(accountDto);
                }
                else
                {
                    _inactiveAccountsDataBindingList.Add(accountDto);
                }
            }
        }

        #region Обработчики кнопок

        private async void buttonStartSession_Click(object sender, EventArgs e)
        {
            // Сохранение изменений в БД
            await SaveChangesAsync(_cancellationToken);
            DialogResult = DialogResult.OK;
        }

        private async void buttonSaveSetupSettings_Click(object sender, EventArgs e)
        {
            // Сохранение изменений в БД
            await SaveChangesAsync(_cancellationToken);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonMoveInactiveAccount_Click(object sender, EventArgs e)
        {
            if (dataGridViewInactiveAccounts.CurrentRow?.DataBoundItem is not AccountDto accountDto)
                return;

            _inactiveAccountsDataBindingList.Remove(accountDto);
            _activeAccountsDataBindingList.Add(accountDto);

            ChangeAccountStatus(accountDto);
        }

        private void buttonMoveInactiveAllAccount_Click(object sender, EventArgs e)
        {
            for (int i = dataGridViewInactiveAccounts.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridViewInactiveAccounts.Rows[i];

                if (!row.IsNewRow && row.DataBoundItem is AccountDto accountDto)
                {
                    _inactiveAccountsDataBindingList.Remove(accountDto);
                    _activeAccountsDataBindingList.Add(accountDto);

                    ChangeAccountStatus(accountDto);
                }
            }
        }

        private void buttonMoveActiveAccount_Click(object sender, EventArgs e)
        {
            if (dataGridViewActiveAccounts.CurrentRow?.DataBoundItem is not AccountDto accountDto)
                return;

            _activeAccountsDataBindingList.Remove(accountDto);
            _inactiveAccountsDataBindingList.Add(accountDto);

            ChangeAccountStatus(accountDto);
        }

        private void buttonMoveActiveAllAccount_Click(object sender, EventArgs e)
        {
            for (int i = dataGridViewActiveAccounts.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridViewActiveAccounts.Rows[i];

                if (!row.IsNewRow && row.DataBoundItem is AccountDto accountDto)
                {
                    _activeAccountsDataBindingList.Remove(accountDto);
                    _inactiveAccountsDataBindingList.Add(accountDto);

                    ChangeAccountStatus(accountDto);
                }
            }
        }

        private async void buttonAddAccount_Click(object sender, EventArgs e)
        {
            AddAccountForm addAccountForm = new AddAccountForm();

            if (addAccountForm.ShowDialog() == DialogResult.OK)
            {
                AccountDto accountDto = addAccountForm.GetDataForNewAccount();

                await _accountsService.AddNewAccountAsync(accountDto, _cancellationToken);
                await FillAccountsDataOnFormAsync(_cancellationToken);
            }
        }

        private async void buttonRemoveAccount_Click(object sender, EventArgs e)
        {
            if (dataGridViewInactiveAccounts.CurrentRow?.DataBoundItem is not AccountDto accountDto)
                return;

            if (MessageBox.Show(
                    $"Удалить аккаунт: {accountDto.Login}?",
                    "Удаление",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
            {
                await RemoveAccountAsync(accountDto, _cancellationToken);
                await FillAccountsDataOnFormAsync(_cancellationToken);
            }
        }

        private void dataGridViewActiveAccounts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewActiveAccounts.CurrentRow?.DataBoundItem is not AccountDto accountDto ||
                dataGridViewActiveAccounts.RowCount == 0)
                return;

            FillAccountSettingsOnForm(accountDto);

            FillAccountLinksOnForm(accountDto);
        }

        private async void buttonImportAccounts_Click(object sender, EventArgs e)
        {
            // Сохранение изменений в БД
            await SaveChangesAsync(_cancellationToken);

            FileProcessor fileProcessor = new FileProcessor();
            var accountsDto = await fileProcessor.AccountsFileProcess(_cancellationToken);

            await _accountsService.AddNewAccountsAsync(
                accountsDto,
                _cancellationToken);

            await FillAccountsDataOnFormAsync(_cancellationToken);
        }

        private void dataGridViewActiveAccounts_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            // Обновление состояния настроек для аккаунта
            UpdateStatementSettings();
        }

        private void buttonSetSettingsForAllAccounts_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewActiveAccounts.Rows)
            {
                if (!row.IsNewRow && row.DataBoundItem is AccountDto accountDto)
                {
                    Account? account = _accounts.FirstOrDefault(a => a.Id == accountDto.Id);
                    if (account is null)
                        continue;

                    SettingState readBook = new SettingState(
                        checkBoxReadBook.Checked,
                        (int)numericOrderReadBook.Value);

                    SettingState addToLibrary = new SettingState(
                        checkBoxAddToLibrary.Checked,
                        (int)numericOrderAddToLibrary.Value);

                    SettingState likeTheBook = new SettingState(
                        checkBoxLikeTheBook.Checked,
                        (int)numericOrderLikeBook.Value);

                    SettingState subscribeToTheAuthor = new SettingState(
                        checkBoxSubscribeToTheAuthor.Checked,
                        (int)numericOrderSubscribeToTheAuthor.Value);

                    SettingState postComment = new SettingState(
                        checkBoxPostComment.Checked,
                        (int)numericOrderPostComment.Value);

                    SettingState makeADonation = new SettingState(checkBoxMakeADonationToTheAuthor.Checked,
                        (int)numericOrderDonateAuthor.Value);

                    SettingState buyABook = new SettingState(
                        checkBoxBuyABook.Checked,
                        (int)numericOrderBuyABook.Value);

                    ReadProfile readProfile = comboBoxReadProfile.Text.ToReadProfile();

                    account.AccountSettings.UpdateSettings(
                        readBook,
                        addToLibrary,
                        likeTheBook,
                        subscribeToTheAuthor,
                        postComment,
                        makeADonation,
                        buyABook,
                        readProfile);

                    account.MarkAsModified();
                }
            }            
        }

        #endregion

        public List<Account> GetActiveAccountsForStart()
        {
            // Возвращаем список выбранных (активных) аккаунтов
            HashSet<int> activeAccountsIds = _activeAccountsDataBindingList
                .Select(a => a.Id)
                .ToHashSet();

            List<Account> accounts = _accounts
                .Where(a => activeAccountsIds.Contains(a.Id))
                .ToList();

            return accounts;
        }

        private async Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            UpdateStatementSettings();

            List<Account> accountsForUpdate = _accounts
                .Where(a => a.IsModified)
                .ToList();

            await _accountsService.SaveChangesForManyAccountsAsync(accountsForUpdate, cancellationToken);
            await FillAccountsDataOnFormAsync(cancellationToken);
        }

        private void FillAccountSettingsOnForm(AccountDto accountDto)
        {
            Account? account = _accounts.FirstOrDefault(a => a.Id == accountDto.Id);

            if (account is not null)
            {
                checkBoxReadBook.Checked = account.AccountSettings.ReadBook.Enabled;
                checkBoxLikeTheBook.Checked = account.AccountSettings.LikeTheBook.Enabled;
                checkBoxAddToLibrary.Checked = account.AccountSettings.AddToLibrary.Enabled;
                checkBoxSubscribeToTheAuthor.Checked = account.AccountSettings.SubscribeToTheAuthor.Enabled;
                checkBoxPostComment.Checked = account.AccountSettings.PostComment.Enabled;
                checkBoxMakeADonationToTheAuthor.Checked = account.AccountSettings.MakeADonationToTheAuthor.Enabled;
                checkBoxBuyABook.Checked = account.AccountSettings.BuyABook.Enabled;

                numericOrderReadBook.Value = account.AccountSettings.ReadBook.Order;
                numericOrderLikeBook.Value = account.AccountSettings.LikeTheBook.Order;
                numericOrderAddToLibrary.Value = account.AccountSettings.AddToLibrary.Order;
                numericOrderSubscribeToTheAuthor.Value = account.AccountSettings.SubscribeToTheAuthor.Order;
                numericOrderPostComment.Value = account.AccountSettings.PostComment.Order;
                numericOrderDonateAuthor.Value = account.AccountSettings.MakeADonationToTheAuthor.Order;
                numericOrderBuyABook.Value = account.AccountSettings.BuyABook.Order;

                comboBoxReadProfile.Text = account.AccountSettings.ReadProfile.ToDisplayString();
            }
            else
            {
                checkBoxReadBook.Checked = false;
                checkBoxLikeTheBook.Checked = false;
                checkBoxAddToLibrary.Checked = false;
                checkBoxSubscribeToTheAuthor.Checked = false;
                checkBoxPostComment.Checked = false;
                checkBoxMakeADonationToTheAuthor.Checked = false;
                checkBoxBuyABook.Checked = false;

                numericOrderReadBook.Value = 0;
                numericOrderLikeBook.Value = 0;
                numericOrderAddToLibrary.Value = 0;
                numericOrderSubscribeToTheAuthor.Value = 0;
                numericOrderPostComment.Value = 0;
                numericOrderDonateAuthor.Value = 0;
                numericOrderBuyABook.Value = 0;
            }
        }

        private void UpdateMainInfo(AccountDto accountDto)
        {
            Account? account = _accounts.FirstOrDefault(a => a.Id == accountDto.Id);
            if (account is null)
                return;

            account.UpdateMainInformation(
                accountDto.Login,
                accountDto.Password,
                accountDto.LitNet,
                accountDto.LitMarket);
        }

        private void UpdateStatementSettings()
        {
            if (dataGridViewActiveAccounts.CurrentRow?.DataBoundItem is not AccountDto accountDto)
                return;

            Account? account = _accounts.FirstOrDefault(a => a.Id == accountDto.Id);
            if (account is null)
                return;

            SettingState readBook = new SettingState(
                checkBoxReadBook.Checked,
                (int)numericOrderReadBook.Value);

            SettingState addToLibrary = new SettingState(
                checkBoxAddToLibrary.Checked,
                (int)numericOrderAddToLibrary.Value);

            SettingState likeTheBook = new SettingState(
                checkBoxLikeTheBook.Checked,
                (int)numericOrderLikeBook.Value);

            SettingState subscribeToTheAuthor = new SettingState(
                checkBoxSubscribeToTheAuthor.Checked,
                (int)numericOrderSubscribeToTheAuthor.Value);

            SettingState postComment = new SettingState(
                checkBoxPostComment.Checked,
                (int)numericOrderPostComment.Value);

            SettingState makeADonation = new SettingState(checkBoxMakeADonationToTheAuthor.Checked,
                (int)numericOrderDonateAuthor.Value);

            SettingState buyABook = new SettingState(
                checkBoxBuyABook.Checked,
                (int)numericOrderBuyABook.Value);

            ReadProfile readProfile = comboBoxReadProfile.Text.ToReadProfile();

            account.AccountSettings.UpdateSettings(
                readBook,
                addToLibrary,
                likeTheBook,
                subscribeToTheAuthor,
                postComment,
                makeADonation,
                buyABook,
                readProfile);

            account.MarkAsModified();
        }

        private void ChangeAccountStatus(AccountDto accountDto)
        {
            Account? account = _accounts.FirstOrDefault(a => a.Id == accountDto.Id);
            if (account is not null)
                account.ChangeActivityStatus();
        }

        private async Task RemoveAccountAsync(AccountDto? accountDto, CancellationToken cancellationToken)
        {
            if (accountDto is null)
                return;

            await _accountsService.RemoveAccountByLoginAsync(accountDto.Login, cancellationToken);
        }

        private async void buttonClearAccounts_Click(object sender, EventArgs e)
        {
            if (dataGridViewInactiveAccounts.Rows.Count == 0)
                return;

            if (MessageBox.Show(
                    "Удалить все аккаунты?",
                    "Удаление",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
            {
                for (int i = dataGridViewInactiveAccounts.Rows.Count - 1; i >= 0; i--)
                {
                    DataGridViewRow row = dataGridViewInactiveAccounts.Rows[i];

                    if (!row.IsNewRow && row.DataBoundItem is AccountDto accountDto)
                    {
                        await RemoveAccountAsync(accountDto, _cancellationToken);
                        await FillAccountsDataOnFormAsync(_cancellationToken);
                    }
                }
            }
        }

        private async void dataGridViewInactiveAccounts_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            buttonRemoveAccount_Click(sender, e);
        }

        #region Links
        private void FillAccountLinksOnForm(AccountDto accountDto)
        {
            Account? account = _accounts.FirstOrDefault(a => a.Id == accountDto.Id);

            if (account is not null)
            {
                foreach (DataGridViewRow row in dataGridViewLinks.Rows)
                {
                    if (!row.IsNewRow && row.DataBoundItem is Data.Links link)
                    {
                        if (link.AccountsId != null && link.AccountsId.Contains(account.Id))
                        {
                            row.Cells[0].Value = true;
                        }
                        else
                        {
                            row.Cells[0].Value = false;
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewLinks.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }
        }

        private void dataGridViewLinks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Если фокус пользователя не на элементе dataGridViewLinks, то не отрабатываем событие
            if (ActiveControl != null && ActiveControl.Name != dataGridViewLinks.Name)
            {
                return;
            }

            if (dataGridViewLinks.CurrentRow?.DataBoundItem is not Data.Links link ||
                dataGridViewLinks.RowCount == 0)
                return;

            if (dataGridViewActiveAccounts.CurrentRow?.DataBoundItem is not AccountDto accountDto ||
                dataGridViewActiveAccounts.RowCount == 0)
                return;

            if (link.AccountsId == null)
            {
                link.AccountsId = new List<int>();
            }

            if ((bool)dataGridViewLinks.CurrentCell.Value)
            {
                if (!link.AccountsId.Contains(accountDto.Id))
                {
                    link.AccountsId.Add(accountDto.Id);
                }
            }
            else
            {
                if (link.AccountsId.Contains(accountDto.Id))
                {
                    link.AccountsId.Remove(accountDto.Id);
                }
            }

            SaveData();
        }

        private void dataGridViewLinks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что кликнули по булевой колонке
            if (e.ColumnIndex == dataGridViewLinks.Columns["dataGridViewTextBoxColumn6"].Index && e.RowIndex >= 0)
            {
                // Принудительно фиксируем изменение
                dataGridViewLinks.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void buttonSelectAllLinksForAllAccounts_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewActiveAccounts.Rows)
            {
                if (!row.IsNewRow && row.DataBoundItem is AccountDto accountDto)
                {
                    SelectAllLinks(accountDto);
                }
            }
        }

        private void buttonClearLinksSelectionForAllAccounts_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewActiveAccounts.Rows)
            {
                if (!row.IsNewRow && row.DataBoundItem is AccountDto accountDto)
                {
                    DeselectAllLinks(accountDto);
                }
            }
        }

        private void buttonSelectAllLinksForSelectedAccounts_Click(object sender, EventArgs e)
        {
            if (dataGridViewActiveAccounts.CurrentRow?.DataBoundItem is not AccountDto accountDto ||
                dataGridViewActiveAccounts.RowCount == 0)
                return;

            SelectAllLinks(accountDto);
        }

        private void buttonClearLinksSelectionForSelectedAccounts_Click(object sender, EventArgs e)
        {
            if (dataGridViewActiveAccounts.CurrentRow?.DataBoundItem is not AccountDto accountDto ||
                dataGridViewActiveAccounts.RowCount == 0)
                return;

            DeselectAllLinks(accountDto);
        }

        private void SelectAllLinks(AccountDto accountDto)
        {
            foreach (Data.Links link in _links)
            {
                if (link.AccountsId == null)
                {
                    link.AccountsId = new List<int>();
                }

                if (!link.AccountsId.Contains(accountDto.Id))
                {
                    link.AccountsId.Add(accountDto.Id);
                }

                SaveData();
            }

            LoadData();

            FillAccountLinksOnForm(accountDto);
        }

        private void DeselectAllLinks(AccountDto accountDto)
        {
            foreach (Data.Links link in _links)
            {
                if (link.AccountsId == null)
                {
                    link.AccountsId = new List<int>();
                }

                if (link.AccountsId.Contains(accountDto.Id))
                {
                    link.AccountsId.Remove(accountDto.Id);
                }

                SaveData();
            }

            LoadData();

            FillAccountLinksOnForm(accountDto);
        }
        #endregion
    
    }
}