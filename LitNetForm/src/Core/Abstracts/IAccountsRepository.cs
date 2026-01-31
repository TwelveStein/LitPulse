using Core.Entities;

namespace Core.Abstracts;

public interface IAccountsRepository
{
    Task<bool> CheckExistAccountByIdAsync(int accountId, CancellationToken cancellationToken);
    
    Task AddNewAccountAsync(Account account, CancellationToken cancellationToken);
    
    Task AddManyAccountsAsync(IReadOnlyList<Account> accounts, CancellationToken cancellationToken);

    Task<List<Account>> GetAllAccountsWithSettingsAsync(CancellationToken cancellationToken);

    Task SaveChangesForManyAccountsAsync(IReadOnlyList<Account> accounts, CancellationToken cancellationToken);

    Task <IReadOnlyList<string>> CheckExistingAccountsByLoginAsync(IReadOnlyList<string> logins, CancellationToken cancellationToken);
    
    Task RemoveAccountByLoginAsync(string login, CancellationToken cancellationToken);
}