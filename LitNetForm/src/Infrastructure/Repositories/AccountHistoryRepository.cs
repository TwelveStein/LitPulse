using Core.Abstracts;
using Core.Entities;

namespace Infrastructure.Repositories;

public class AccountHistoryRepository : IAccountHistoryRepository
{
    public async Task AddActionAsync(AccountActionHistory accountActionHistory, CancellationToken cancellationToken)
    {
    }
}