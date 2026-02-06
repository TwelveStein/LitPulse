using Contracts.DTOs;
using Core.Entities;
using Core.Enums;
using Core.Factory;
using Core.Services;

namespace Core.Handlers;

/// <summary>
/// Обработчик выполнения сервиса в одном экземпляре
/// </summary>
public class StartSingleThreadHandler
{
    private readonly ServiceFactory _serviceFactory;
    private readonly ReportService _reportService;

    public StartSingleThreadHandler(ServiceFactory serviceFactory, ReportService reportService)
    {
        _serviceFactory = serviceFactory;
        _reportService = reportService;
    }

    /// <summary>
    /// Старт обработчика
    /// </summary>
    public async Task HandleAsync(
        IReadOnlyList<Account> activeAccounts,
        string[] litNetLinks,
        string[] litMarketLinks,
        Action<string> logger,
        CancellationToken cancellationToken)
    {
        Guid sessionId = Guid.NewGuid();
        WriteStartSession(sessionId);
        
        try
        {
            foreach (var account in activeAccounts)
            {
                if (cancellationToken.IsCancellationRequested)
                    return;

                if (account.LitNet is false)
                    continue;

                try
                {
                    await _serviceFactory.ExecuteInService<StartLitNetHandler>(async handler =>
                        await handler.HandleAsync(
                            sessionId,
                            account,
                            litNetLinks,
                            logger,
                            cancellationToken));
                }
                catch (OperationCanceledException)
                {
                    logger("Сервис остановлен.");
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            foreach (var account in activeAccounts)
            {
                if (cancellationToken.IsCancellationRequested)
                    return;

                if (account.LitMarket is false)
                    continue;

                try
                {
                    await _serviceFactory.ExecuteInService<StartLitMarketHandler>(async handler =>
                        await handler.HandleAsync(
                            sessionId,
                            account,
                            litMarketLinks,
                            logger,
                            cancellationToken));
                }
                catch (OperationCanceledException)
                {
                    logger("Сервис остановлен.");
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }
        finally
        {
            WriteStopSession(sessionId);
        }
    }

    private void WriteStartSession(Guid sessionId)
    {
        ReportDataDto reportDataDto = new ReportDataDto
        {
            SessionId = sessionId,
            Operation = AccountActionType.StartSession.ToDisplayString(),
            SessionDateTime = DateTime.Now,
        };
        
        _reportService.AddReportItem(reportDataDto);
    }
    
    private void WriteStopSession(Guid sessionId)
    {
        ReportDataDto reportDataDto = new ReportDataDto
        {
            SessionId = sessionId,
            Operation = AccountActionType.StopSession.ToDisplayString(),
            SessionDateTime = DateTime.Now,
        };
        
        _reportService.AddReportItem(reportDataDto);
    }
}