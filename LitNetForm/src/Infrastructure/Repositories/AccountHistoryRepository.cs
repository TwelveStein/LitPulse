using Core.Abstracts;
using Core.Entities;
using Infrastructure.Database;

namespace Infrastructure.Repositories;

public class AccountHistoryRepository(AppDbContext dbContext) : IAccountHistoryRepository
{
    public async Task AddActionAsync(AccountActionHistory accountActionHistory, CancellationToken cancellationToken)
    {
        try
        {
            await dbContext.AccountActionHistories.AddAsync(accountActionHistory, cancellationToken);
            await dbContext.SaveChangesAsync(cancellationToken);
        }
        catch (Exception)
        {
            // ignored
        }
    }
}