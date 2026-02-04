using Core.Entities;
using Core.Services;
using Core.Settings;
using Microsoft.Playwright;

namespace Core.Handlers;

/// <summary>
/// Обработчик LitNet - запускает LitNetService
/// </summary>
public sealed class StartLitNetHandler
{
    private const string LIT_NET_LINK_LOGIN =
        "https://litnet.com/auth/login?classic=1&link=https%3A%2F%2Flitnet.com%2Fru%2Fbook%2Fvozmu-tebya-b531445";
    
    private readonly LitNetService _litNetService;
    
    public StartLitNetHandler(LitNetService litNetService)
    {
        _litNetService = litNetService;
    }
    
    /// <summary>
    /// Старт обработчика LitNet
    /// </summary>
    public async Task HandleAsync(
        Account account,
        string[] litNetLinks,
        Action<string> logger,
        CancellationToken cancellationToken)
    {
        try
        {
            if (litNetLinks.Length != 0)
            {
                logger("Запуск эмуляции чтения https://litnet.com ...");

                await _litNetService.InitializeAsync();

                foreach (var link in litNetLinks.Take(3))
                {
                    await _litNetService.PrimaryActivity(link, logger, cancellationToken);
                }

                if (await _litNetService.Login(account.Login, account.Password, LIT_NET_LINK_LOGIN))
                {
                    logger($"Выполнен вход в аккаунт {account.Login}");

                    foreach (var link in litNetLinks)
                    {
                        await _litNetService.BaseActivityBotAsync(
                            account.Id,
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
            logger($"[X] Ошибка: {ex.Message}.");
        }
        finally
        {
            await _litNetService.DisposeAsync();
        }
    }
}