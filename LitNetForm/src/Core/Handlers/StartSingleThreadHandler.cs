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

            StartLitNetHandler handler = await _serviceFactory.GetServiceAsync<StartLitNetHandler>();

            try
            {
                await handler.HandleAsync(
                    account,
                    litNetLinks,
                    logger,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                Log(logger, "Сервис остановлен.");
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
                StartLitMarketHandler handler = await _serviceFactory.GetServiceAsync<StartLitMarketHandler>();

                await handler.HandleAsync(
                    account,
                    litMarketLinks,
                    logger,
                    cancellationToken);
            }
            catch (Exception ex)
            {
                Log(logger, "Сервис остановлен.");
            }
        }
    }
    
    private static void Log(Action<string>? cb, string m) =>
        cb?.Invoke($"[{DateTime.Now:HH:mm:ss.fff}] {m}");
}