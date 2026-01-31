using Contracts.Enums;

namespace Contracts.DTOs;

public record AccountActionDto(
    int AccountId,
    AccountActionType ActionType,
    string Target,
    string ActionResult);