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

    // Используем примитив синхронизации для ограничения доступа указанному кол-ву потоков
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

        var litNetTasks = activeAccounts
            .Where(account => account.LitNet)
            .Select(account => RunWithScopeAsync<StartLitNetHandler>(handler => handler.HandleAsync(
                    account,
                    litNetLinks,
                    logger,
                    cancellationToken),
                logger,
                delay,
                cancellationToken));

        var litMarketTasks = activeAccounts
            .Where(account => account.LitMarket)
            .Select(account => RunWithScopeAsync<StartLitNetHandler>(handler => handler.HandleAsync(
                    account,
                    litMarketLinks,
                    logger,
                    cancellationToken),
                logger,
                delay,
                cancellationToken));

        await Task.WhenAll(litNetTasks);
        await Task.WhenAll(litMarketTasks);
    }

    private async Task RunWithScopeAsync<THandler>(
        Func<THandler, Task> action,
        Action<string> logger,
        int delay,
        CancellationToken cancellationToken)
        where THandler : notnull
    {
        try
        {
            await _semaphoreSlim.WaitAsync(cancellationToken);

            try
            {
                // Обязательно для каждого потока получаем отдельный сервис
                var handler = await _serviceFactory.GetServiceAsync<THandler>();

                Log(logger, $"Задержка перед запуском: {delay / 1000} секунд.");
                await Task.Delay(delay, cancellationToken);

                await action(handler);
            }
            finally
            {
                _semaphoreSlim.Release();
            }
        }
        catch (Exception ex)
        {
        }
    }

    private static void Log(Action<string>? cb, string m) =>
        cb?.Invoke($"[{DateTime.Now:HH:mm:ss.fff}] {m}");

    public void Dispose()
    {
        _semaphoreSlim.Dispose();
    }
}