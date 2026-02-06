namespace Contracts.DTOs;

public sealed record UserContextDto(
    int AccountId,
    string Login);