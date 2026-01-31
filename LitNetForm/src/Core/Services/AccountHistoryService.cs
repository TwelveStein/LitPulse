using Contracts.DTOs;
using Core.Abstracts;
using Core.Entities;

namespace Core.Services;

public sealed class AccountHistoryService(
    IAccountsRepository accountsRepository,
    IAccountHistoryRepository accountHistoryRepository)
{
    public async Task AddActionAsync(AccountActionDto accountActionDto, CancellationToken cancellationToken)
    {
        bool accountExistResult = await accountsRepository
            .CheckExistAccountByIdAsync(accountActionDto.AccountId, cancellationToken);
        
        if (accountExistResult is false)
            return;
        
        AccountActionHistory accountActionHistory = new AccountActionHistory(
            accountActionDto.AccountId,
            accountActionDto.ActionType,
            accountActionDto.Target,
            accountActionDto.ActionResult);
        
        await accountHistoryRepository.AddActionAsync(accountActionHistory, cancellationToken);
    }
}