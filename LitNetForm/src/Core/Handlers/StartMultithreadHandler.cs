using Contracts.DTOs;
using Core.Entities;
using Core.Factory;
using Core.Services;

namespace Core.Handlers;

/// <summary>
/// Обработчик многопоточного выполнения сервисов, без порций
/// </summary>
public sealed class StartMultithreadHandler : IDisposable
{
    private readonly ServiceFactory _serviceFactory;
    private readonly ReportService _reportService;

    // Используем примитив синхронизации для ограничения количества потоков
    private SemaphoreSlim _semaphoreSlim = null!;

    public StartMultithreadHandler(
        ServiceFactory serviceFactory, 
        ReportService reportService)
    {
        _serviceFactory = serviceFactory;
        _reportService = reportService;
    }

    /// <summary>
    /// Старт обработчика многопоточного выполнения сервисов
    /// </summary>
    public async Task HandleAsync(
        IReadOnlyList<Account> activeAccounts,
        int accountsCount,
        string[] litNetLinks,
        string[] litMarketLinks,
        DelayDto delayDto,
        Action<string> logger,
        CancellationToken cancellationToken)
    {
        _semaphoreSlim = new SemaphoreSlim(accountsCount);

        Random random = new Random();
        int floatingDelay = random.Next(delayDto.FloatingIncrementalDelay);
        int delay = (delayDto.ConstantDelay + floatingDelay) * 1000;

        Guid sessionId = Guid.NewGuid();
        _reportService.WriteStartSession(sessionId);

        try
        {
            List<Task> litNetTasks = [];
            if (litNetLinks.Length > 0)
            {
                litNetTasks = activeAccounts
                    .Where(account => account.LitNet)
                    .Select(account => _serviceFactory.ExecuteInService<StartLitNetHandler>(async handler =>
                    {
                        await _semaphoreSlim.WaitAsync(cancellationToken);

                        logger($"Задержка перед запуском: {delay / 1000} секунд.");
                        await Task.Delay(delay, cancellationToken);

                        try
                        {
                            await handler.HandleAsync(
                                sessionId,
                                account,
                                litNetLinks,
                                logger,
                                cancellationToken);
                        }
                        finally
                        {
                            _semaphoreSlim.Release();
                        }
                    }))
                    .ToList();
            }

            List<Task> litMarketTasks = [];
            if (litMarketLinks.Length > 0)
            {
                litMarketTasks = activeAccounts
                    .Where(account => account.LitMarket)
                    .Select(account => _serviceFactory.ExecuteInService<StartLitMarketHandler>(async handler =>
                    {
                        await _semaphoreSlim.WaitAsync(cancellationToken);

                        logger($"Задержка перед запуском: {delay / 1000} секунд.");
                        await Task.Delay(delay, cancellationToken);

                        try
                        {
                            await handler.HandleAsync(
                                sessionId,
                                account,
                                litMarketLinks,
                                logger,
                                cancellationToken);
                        }
                        finally
                        {
                            _semaphoreSlim.Release();
                        }
                    }))
                    .ToList();
            }
            await Task.WhenAll(litNetTasks);
            await Task.WhenAll(litMarketTasks);
        }
        catch (OperationCanceledException)
        {
            logger("Операция остановлена.");
        }
        catch (Exception)
        {
            // ignored
        }
        finally
        {
            _reportService.WriteStopSession(sessionId);
        }
    }
    
    public void Dispose()
    {
        if (_semaphoreSlim is not null)
            _semaphoreSlim.Dispose();
    }
}