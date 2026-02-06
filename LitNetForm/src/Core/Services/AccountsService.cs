using Contracts.DTOs;
using Core.Abstracts;
using Core.Entities;
using Core.Entities.ValueObjects;
using Core.Enums;

namespace Core.Services;

public sealed class AccountsService(IAccountsRepository repository)
{
    /// <summary>
    /// Создает новый аккаунт
    /// </summary>
    public async Task AddNewAccountAsync(AccountDto accountDto, CancellationToken cancellationToken)
    {
        var existsAccountLogin = await repository
            .CheckExistingAccountsByLoginAsync([accountDto.Login], cancellationToken);

        if (existsAccountLogin.Any())
            return;

        Account account = new Account(
            accountDto.Login,
            accountDto.Password,
            accountDto.LitNet,
            accountDto.LitMarket,
            CreateDefaultSettingsForAccount());

        await repository.AddNewAccountAsync(account, cancellationToken);
    }

    /// <summary>
    /// Возвращает список аккаунтов с их настройками
    /// </summary>
    public async Task<List<Account>> GetAllAccountsWithSettingsAsync(CancellationToken cancellationToken)
    {
        var accounts = await repository.GetAllAccountsWithSettingsAsync(cancellationToken);
        return accounts;
    }

    /// <summary>
    /// Сохраняет изменения для списка аккаунтов
    /// </summary>
    public async Task SaveChangesForManyAccountsAsync(
        IReadOnlyList<Account> accounts,
        CancellationToken cancellationToken)
    {
        foreach (var account in accounts)
        {
            account.MarkAsUnmodified();
        }

        await repository.SaveChangesForManyAccountsAsync(accounts, cancellationToken);
    }

    /// <summary>
    /// Создаёт множество новых аккаунтов
    /// </summary>
    public async Task AddNewAccountsAsync(
        IReadOnlyList<AccountDto> accountsDto,
        CancellationToken cancellationToken)
    {
        var logins = accountsDto.Select(a => a.Login).ToList();

        var existsAccountsLogin = await repository.CheckExistingAccountsByLoginAsync(
            logins,
            cancellationToken);

        List<Account> newAccounts = [];
        foreach (var accountDto in accountsDto)
        {
            if (existsAccountsLogin.Contains(accountDto.Login))
                continue;

            var defaultSettings = CreateDefaultSettingsForAccount();

            Account account = new Account(
                accountDto.Login,
                accountDto.Password,
                accountDto.LitNet,
                accountDto.LitMarket,
                defaultSettings);
            
            newAccounts.Add(account);
        }

        await repository.AddManyAccountsAsync(newAccounts, cancellationToken);
    }

    /// <summary>
    /// Удаляет аккаунт по Id
    /// </summary>
    public async Task RemoveAccountByLoginAsync(string login, CancellationToken cancellationToken)
    {
        await repository.RemoveAccountByLoginAsync(login, cancellationToken);
    }

    /// <summary>
    /// Создает дефолтные настройки для аккаунта
    /// </summary>
    private static AccountSettings CreateDefaultSettingsForAccount()
    {
        // Задаём основные настройки аккаунту (настройки по умолчанию)
        AccountSettings accountSettings = new AccountSettings
        {
            ReadBook = new SettingState(true, 1),
            AddToLibrary = new SettingState(true, 2),
            LikeTheBook = new SettingState(true, 3),
            SubscribeToTheAuthor = new SettingState(true, 4),
            PostComment = new SettingState(true, 5),
            MakeADonationToTheAuthor = new SettingState(true, 6),
            BuyABook = new SettingState(true, 7),
            ConstantDelay = 1000,
            FloatingIncrementalDelay = 500,
            ReadProfile = ReadProfile.DeepReader
        };

        return accountSettings;
    }
}