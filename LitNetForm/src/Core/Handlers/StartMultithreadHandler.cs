using Contracts.DTOs;
using Core.Entities;
using Core.Factory;

namespace Core.Handlers;

/// <summary>
/// Обработчик многопоточного выполнения сервисов, без порций
/// </summary>
public sealed class StartMultithreadHandler : IDisposable
{
    private readonly ServiceFactory _serviceFactory;

    // Используем примитив синхронизации для ограничения количества потоков
    private SemaphoreSlim _semaphoreSlim = null!;

    public StartMultithreadHandler(ServiceFactory serviceFactory)
    {
        _serviceFactory = serviceFactory;
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
        Random random = new Random();

        _semaphoreSlim = new SemaphoreSlim(accountsCount);

        int floatingDelay = random.Next(delayDto.FloatingIncrementalDelay);
        int delay = (delayDto.ConstantDelay + floatingDelay) * 1000;

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

                        try
                        {
                            await handler.HandleAsync(
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
        catch (Exception ex)
        {
            // ignored
        }
    }

    public void Dispose()
    {
        if (_semaphoreSlim is not null)
            _semaphoreSlim.Dispose();
    }
}