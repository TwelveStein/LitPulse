using Contracts.DTOs;
using Core.Entities;
using Core.Services;
using Core.Settings;
using Microsoft.Playwright;

namespace Core.Handlers;

/// <summary>
/// Обработчик LitMarket - запускает LitMarketService
/// </summary>
public sealed class StartLitMarketHandler
{
    private const string LIT_MARKET_LINK_LOGIN = "https://litmarket.ru/";

    private readonly LitMarketService _litMarketService;

    public StartLitMarketHandler(LitMarketService litMarketService)
    {
        _litMarketService = litMarketService;
    }

    /// <summary>
    /// Старт обработчика LitMarket
    /// </summary>
    public async Task HandleAsync(
        Guid sessionId,
        Account account,
        string[] litMarketLinks,
        Action<string> logger,
        CancellationToken cancellationToken)
    {
        try
        {
            if (litMarketLinks.Length != 0)
            {
                logger("Запуск эмуляции чтения https://litmarket.ru/ ...");

                await _litMarketService.InitializeAsync();

                if (await _litMarketService.Login(
                        account.Login,
                        account.Password,
                        LIT_MARKET_LINK_LOGIN,
                        logger))
                {
                    logger($"Выполнен вход в аккаунт {account.Login}");

                    foreach (string link in litMarketLinks)
                    {
                        await _litMarketService.ReaderBooks(
                            new UserContextDto(account.Id, account.Login),
                            sessionId,
                            link,
                            logger,
                            new StartupSettings(account.AccountSettings),
                            cancellationToken);

                        logger($"Выполнено чтение по ссылке {link}");
                    }
                }
                else
                {
                    logger($"Неудачная попытка входа в аккаунт. Пользователь: {account.Login}, пароль: {account.Password}");
                }
            }
        }
        catch (OperationCanceledException)
        {
            logger("Остановлено пользователем.");
        }
        catch (PlaywrightException ex)
        {
            // Проверяем по сообщению
            if (ex.Message.Contains("Target closed") ||
                ex.Message.Contains("closed") ||
                ex.Message.Contains("Session closed"))
            {
                logger("Браузер был закрыт.");
            }
            else
            {
                throw;
            }
        }
        catch (Exception ex)
        {
            logger($"[X] Ошибка: {ex.Message}");
        }
        finally
        {
            await _litMarketService.DisposeAsync();
        }
    }
}