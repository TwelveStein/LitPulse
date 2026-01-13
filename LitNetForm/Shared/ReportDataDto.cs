namespace LitPulse.Shared;

public record ReportDataDto(
    string User,
    string IpAddress,
    string Operation,
    string Book,
    int SheetsCount,
    string Status);