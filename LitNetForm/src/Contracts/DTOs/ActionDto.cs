namespace Contracts.DTOs;

public sealed record ActionDto(
    UserContextDto UserContext,
    Guid SessionId,
    string BookUrl);