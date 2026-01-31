using Core.Entities;

namespace Core.Abstracts;

public interface IAccountHistoryRepository
{
    Task AddActionAsync(AccountActionHistory accountActionHistory, CancellationToken cancellationToken);
}