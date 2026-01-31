using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Contracts.Enums;

namespace Core.Entities;

public class AccountActionHistory
{
    [Key]
    public int Id { get; init; }

    public int AccountId { get; private set; }
    
    public AccountActionType ActionType { get; private set; }
    
    public string Target { get; private set; }
    
    public string ActionResult { get; private set; }
    
    public DateTime ActionDate { get; private set; } = DateTime.UtcNow;
    
    // Навигационное свойство
    public Account Account { get; private set; } = null!;

    public AccountActionHistory(
        int accountId, 
        AccountActionType actionType, 
        string target,
        string actionResult)
    {
        AccountId = accountId;
        ActionType = actionType;
        Target = target;
        ActionResult = actionResult;
    }
}