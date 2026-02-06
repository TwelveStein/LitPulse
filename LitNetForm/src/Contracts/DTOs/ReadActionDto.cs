namespace Contracts.DTOs;

public sealed record ReadActionDto(
    UserContextDto UserContext,
    Guid SessionId,
    string BookUrl,
    int SheetsCount);