using Core.Entities;
using Core.Factory;

namespace Core.Handlers;

/// <summary>
/// Обработчик выполнения сервиса в одном экземпляре
/// </summary>
public class StartSingleThreadHandler
{
    private readonly ServiceFactory _serviceFactory;

    public StartSingleThreadHandler(ServiceFactory serviceFactory)
    {
        _serviceFactory = serviceFactory;
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
        foreach (var account in activeAccounts)
        {
            if (cancellationToken.IsCancellationRequested)
                return;

            if (account.LitNet is false)
                continue;

            try
            {
                await _serviceFactory.ExecuteInService<StartLitNetHandler>(async handler => await handler.HandleAsync(
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
                await _serviceFactory.ExecuteInService<StartLitMarketHandler>(
                    async handler => await handler.HandleAsync(
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
}