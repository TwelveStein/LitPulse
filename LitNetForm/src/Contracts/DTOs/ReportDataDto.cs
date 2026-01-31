namespace Contracts.DTOs;

public record ReportDataDto
{
    public string? User { get; init; }
    public string? IpAddress { get; init; }
    public string? Operation { get; init; }
    public string? Book { get; init; }
    public int? SheetsCount { get; init; }
    public string? Status { get; init; }
    public DateTime? SessionDateTime { get; init; }
}