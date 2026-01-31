using Core.Abstracts;
using Core.Entities;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public sealed class AccountsRepository(AppDbContext dbContext) : IAccountsRepository
{
    /// <summary>
    /// Выполняет проверку существования аккаунта по Id в БД
    /// </summary>
    public async Task<bool> CheckExistAccountByIdAsync(int accountId, CancellationToken cancellationToken)
    {
        try
        {
            var result = await dbContext.Accounts
                .AnyAsync(a => a.Id == accountId, cancellationToken);
            
            return result;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    /// <summary>
    /// Создаёт новый аккаунт в БД
    /// </summary>
    public async Task AddNewAccountAsync(Account account, CancellationToken cancellationToken)
    {
        try
        {
            await dbContext.Accounts.AddAsync(account, cancellationToken);
            await dbContext.SaveChangesAsync(cancellationToken);
        }
        catch (Exception ex)
        {
        }
    }

    /// <summary>
    /// Создаёт несколько новых аккаунтов в БД
    /// </summary>
    public async Task AddManyAccountsAsync(IReadOnlyList<Account> accounts, CancellationToken cancellationToken)
    {
        try
        {
            await dbContext.Accounts.AddRangeAsync(accounts, cancellationToken);
            await dbContext.SaveChangesAsync(cancellationToken);
        }
        catch (Exception ex)
        {
        }
    }

    /// <summary>
    /// Получает все аккаунты с их настройками из БД
    /// </summary>
    public async Task<List<Account>> GetAllAccountsWithSettingsAsync(CancellationToken cancellationToken)
    {
        try
        {
            var accounts = await dbContext.Accounts
                .Include(a => a.AccountSettings)
                .ToListAsync(cancellationToken);

            return accounts;
        }
        catch (Exception ex)
        {
            return await Task.FromResult(new List<Account>());
        }
    }

    /// <summary>
    /// Сохраняет изменения для списка аккаунтов
    /// </summary>
    public async Task SaveChangesForManyAccountsAsync(
        IReadOnlyList<Account> accounts, CancellationToken cancellationToken)
    {
        try
        {
            dbContext.Accounts.UpdateRange(accounts);
            await dbContext.SaveChangesAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при сохранении всех изменённых настроек! Message: {ex.Message}");
        }
    }

    /// <summary>
    /// Проверка на аккаунт с существующим логином (возвращает логины, которые совпадают)
    /// </summary>
    public async Task<IReadOnlyList<string>> CheckExistingAccountsByLoginAsync(
        IReadOnlyList<string> logins,
        CancellationToken cancellationToken)
    {
        try
        {
            var accounts = await dbContext.Accounts
                .Where(a => logins.Contains(a.Login))
                .Select(a => a.Login)
                .ToListAsync(cancellationToken);

            return accounts;
        }
        catch (Exception ex)
        {
            return await Task.FromResult(new List<string>());
        }
    }

    /// <summary>
    /// Удаляет аккаунт по логину
    /// </summary>
    public async Task RemoveAccountByLoginAsync(string login, CancellationToken cancellationToken)
    {
        try
        {
            var account = await dbContext.Accounts.FirstOrDefaultAsync(a => a.Login == login, cancellationToken);
            if (account is null)
                return;
            
            dbContext.Accounts.Remove(account);
            await dbContext.SaveChangesAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            
        }
    }
}