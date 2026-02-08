using System.ComponentModel;
using Contracts.DTOs;
using Core.Entities;
using Core.Entities.ValueObjects;
using Core.Services;
using LitPulse.Processors;

namespace LitPulse.Forms
{
    public partial class AccountSetupForm : Form
    {
        private readonly AccountsService _accountsService;

        private readonly BindingList<AccountDto> _activeAccountsDataBindingList = [];
        private readonly BindingList<AccountDto> _inactiveAccountsDataBindingList = [];

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
        }

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

        private void buttonMoveActiveAccount_Click(object sender, EventArgs e)
        {
            if (dataGridViewActiveAccounts.CurrentRow?.DataBoundItem is not AccountDto accountDto)
                return;

            _activeAccountsDataBindingList.Remove(accountDto);
            _inactiveAccountsDataBindingList.Add(accountDto);

            ChangeAccountStatus(accountDto);
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
        }

        private async void buttonImportAccounts_Click(object sender, EventArgs e)
        {
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
            AccountSettings? accountSettings = _accounts
                .FirstOrDefault(a => a.Id == accountDto.Id)!.AccountSettings;

            if (accountSettings is not null)
            {
                checkBoxReadBook.Checked = accountSettings.ReadBook.Enabled;
                checkBoxLikeTheBook.Checked = accountSettings.LikeTheBook.Enabled;
                checkBoxAddToLibrary.Checked = accountSettings.AddToLibrary.Enabled;
                checkBoxSubscribeToTheAuthor.Checked = accountSettings.SubscribeToTheAuthor.Enabled;
                checkBoxPostComment.Checked = accountSettings.PostComment.Enabled;
                checkBoxMakeADonationToTheAuthor.Checked = accountSettings.MakeADonationToTheAuthor.Enabled;
                checkBoxBuyABook.Checked = accountSettings.BuyABook.Enabled;

                numericOrderReadBook.Value = accountSettings.ReadBook.Order;
                numericOrderLikeBook.Value = accountSettings.LikeTheBook.Order;
                numericOrderAddToLibrary.Value = accountSettings.AddToLibrary.Order;
                numericOrderSubscribeToTheAuthor.Value = accountSettings.SubscribeToTheAuthor.Order;
                numericOrderPostComment.Value = accountSettings.PostComment.Order;
                numericOrderDonateAuthor.Value = accountSettings.MakeADonationToTheAuthor.Order;
                numericOrderBuyABook.Value = accountSettings.BuyABook.Order;
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
            if (account is null || account.AccountSettings is null)
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

            account.AccountSettings.UpdateSettings(
                readBook,
                addToLibrary,
                likeTheBook,
                subscribeToTheAuthor,
                postComment,
                makeADonation,
                buyABook);

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
    }
}