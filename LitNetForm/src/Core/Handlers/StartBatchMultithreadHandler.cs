using Contracts.DTOs;
using Core.Entities;
using Core.Enums;
using Core.Factory;
using Core.Services;

namespace Core.Handlers;

/// <summary>
/// Обработчик многопоточного порционного выполнения сервисов
/// </summary>
public sealed class StartBatchMultithreadHandler
{
    private readonly ServiceFactory _serviceFactory;
    private readonly ReportService _reportService;

    public StartBatchMultithreadHandler(ServiceFactory serviceFactory, ReportService reportService)
    {
        _serviceFactory = serviceFactory;
        _reportService = reportService;
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
        
        Guid sessionId = Guid.NewGuid();
        _reportService.WriteStartSession(sessionId);
        
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
            .Select((account, index) => new { link = account, index })
            .GroupBy(x => x.index / batchSize)
            .Select(g => g.Select(x => x.link))
            .ToList();

        // Фильтруем и обрабатываем аккаунты LitNet
        foreach (var batch in batches)
        {
            if (litNetLinks.Length == 0)
                break;

            try
            {
                logger($"Задержка перед запуском: {delay / 1000} секунд.");
                await Task.Delay(delay, cancellationToken);

                var litNetTasks = batch
                    .Where(account => account.LitNet)
                    .Select(async account =>
                    {
                        await _serviceFactory.ExecuteInService<StartLitNetHandler>(async handler =>
                            await handler.HandleAsync(
                                sessionId,
                                account,
                                litNetLinks,
                                logger,
                                cancellationToken));
                    })
                    .ToList();

                await Task.WhenAll(litNetTasks);
            }
            catch (OperationCanceledException)
            {
                logger("Порционная операция отменена.");
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        // Фильтруем и обрабатываем аккаунты LitMarket
        foreach (var batch in batches)
        {
            if (litMarketLinks.Length == 0)
                break;

            try
            {
                logger($"Задержка перед запуском: {delay / 1000} секунд.");
                await Task.Delay(delay, cancellationToken);

                var litMarketTasks = batch
                    .Where(account => account.LitMarket)
                    .Select(async account =>
                    {
                        await _serviceFactory.ExecuteInService<StartLitMarketHandler>(async handler =>
                            await handler.HandleAsync(
                                sessionId,
                                account,
                                litMarketLinks,
                                logger,
                                cancellationToken));
                    })
                    .ToList();

                await Task.WhenAll(litMarketTasks);
            }
            catch (OperationCanceledException)
            {
                logger("Порционная операция отменена.");
            }
            catch (Exception)
            {
                // ignored
            }
        }
        _reportService.WriteStopSession(sessionId);
    }
}