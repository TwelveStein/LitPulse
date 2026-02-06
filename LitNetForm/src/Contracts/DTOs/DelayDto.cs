namespace Contracts.DTOs;

public sealed record DelayDto(
    int ConstantDelay,
    int FloatingIncrementalDelay);
