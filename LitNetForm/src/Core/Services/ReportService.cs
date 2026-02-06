using Contracts.DTOs;

namespace Core.Services;

public sealed class ReportService
{
    public event EventHandler<ReportDataDto> ReportItemAdded = null!;

    public void AddReportItem(ReportDataDto item)
    {
        ReportItemAdded?.Invoke(this, item);
    }
}