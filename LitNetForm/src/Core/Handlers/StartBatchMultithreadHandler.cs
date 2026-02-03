using Contracts.DTOs;
using Core.Entities;
using Core.Factory;

namespace Core.Handlers;

/// <summary>
/// Обработчик многопоточного порционного выполнения сервисов
/// </summary>
public sealed class StartBatchMultithreadHandler
{
    private readonly ServiceFactory _serviceFactory;

    public StartBatchMultithreadHandler(ServiceFactory serviceFactory)
    {
        _serviceFactory = serviceFactory;
    }

    /// <summary>
    /// Старт многопоточного порционного обработчика
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

        int floatingDelay = random.Next(delayDto.FloatingIncrementalDelay);
        int delay = (delayDto.ConstantDelay + floatingDelay) * 1000;

        int batchSize = accountsCount;

        // Делим список аккаунтов на порции (batchSize элементов)
        //
        // Пример:
        // activeAccounts = [A, B, C, D, E, F, G]
        // batchSize = 3
        //
        // Результат:
        // [
        //   [A, B, C],
        //   [D, E, F],
        //   [G]
        // ]
        var batches = activeAccounts
            .Select((link, index) => new { link, index })
            .GroupBy(x => x.index / batchSize)
            .Select(g => g.Select(x => x.link))
            .ToList();

        // Фильтруем и обрабатываем аккаунты LitNet
        foreach (var batch in batches)
        {
            Log(logger, $"Задержка перед запуском: {delay / 1000} секунд.");
            await Task.Delay(delay, cancellationToken);

            var litNetTasks = batch
                .Where(account => account.LitNet)
                .Select(async account =>
                {
                    // Обязательно для каждого потока получаем отдельный сервис
                    StartLitNetHandler handler = await _serviceFactory.GetServiceAsync<StartLitNetHandler>();

                    try
                    {
                        await handler.HandleAsync(
                            account,
                            litNetLinks,
                            logger,
                            cancellationToken);
                    }
                    catch (OperationCanceledException)
                    {
                        Log(logger, "Порционная операция отменена.");
                    }
                })
                .ToList();

            await Task.WhenAll(litNetTasks);
        }

        // Фильтруем и обрабатываем аккаунты LitMarket
        foreach (var batch in batches)
        {
            Log(logger, $"Задержка перед запуском: {delay / 1000} секунд.");
            await Task.Delay(delay, cancellationToken);

            var litMarketTasks = batch
                .Where(account => account.LitMarket)
                .Select(async account =>
                {
                    // Обязательно для каждого потока получаем отдельный сервис
                    StartLitMarketHandler handler = await _serviceFactory.GetServiceAsync<StartLitMarketHandler>();

                    try
                    {
                        await handler.HandleAsync(
                            account,
                            litMarketLinks,
                            logger,
                            cancellationToken);
                    }
                    catch (OperationCanceledException)
                    {
                        Log(logger, "Порционная операция отменена.");
                    }
                })
                .ToList();

            await Task.WhenAll(litMarketTasks);
        }
    }

    private static void Log(Action<string>? cb, string m) =>
        cb?.Invoke($"[{DateTime.Now:HH:mm:ss.fff}] {m}");
}