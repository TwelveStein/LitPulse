namespace Contracts.DTOs;

public record DelayDto(
    int ConstantDelay,
    int FloatingIncrementalDelay);
