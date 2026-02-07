using Contracts.DTOs;
using Core.Enums;

namespace Core.Services;

public sealed class ReportService
{
    public event EventHandler<ReportDataDto> ReportItemAdded = null!;

    public void AddReportItem(ReportDataDto item)
    {
        ReportItemAdded?.Invoke(this, item);
    }
    
    public void WriteStartSession(Guid sessionId)
    {
        AddReportItem(new ReportDataDto
        {
            SessionId = sessionId,
            Operation = AccountActionType.StartSession.ToDisplayString(),
            SessionDateTime = DateTime.Now
        });
    }

    public void WriteStopSession(Guid sessionId)
    {
        AddReportItem(new ReportDataDto
        {
            SessionId = sessionId,
            Operation = AccountActionType.StopSession.ToDisplayString(),
            SessionDateTime = DateTime.Now
        });
    }
}