using Contracts.DTOs;
using Contracts.Enums;
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
    private readonly IProgress<ReportDataDto> _reportDataProgress;
    
    public StartLitNetHandler(
        LitNetService litNetService, 
        IProgress<ReportDataDto> reportDataProgress)
    {
        _litNetService = litNetService;
        _reportDataProgress = reportDataProgress;
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
        int litNetSessionCounter = 0;

        try
        {
            if (litNetLinks.Length != 0)
            {
                logger("Запуск эмуляции чтения https://litnet.com ...");

                await _litNetService.InitializeAsync();
                
                _reportDataProgress.Report(new ReportDataDto
                {
                    Operation = "Начало сессии",
                    SessionDateTime = DateTime.Now
                });
                
                litNetSessionCounter++;

                foreach (var link in litNetLinks.Take(3))
                {
                    await _litNetService.PrimaryActivity(link, logger);
                }

                if (await _litNetService.Login(account.Login, account.Password, LIT_NET_LINK_LOGIN))
                {
                    logger($"Выполнен вход в аккаунт {account.Login}");

                    foreach (var link in litNetLinks)
                    {
                        int sheetsCount = await _litNetService.BaseActivityBot(
                            link, 
                            logger, 
                            account.AccountSettings.ReadProfile, 
                            new StartupSettings(account.AccountSettings));

                        logger($"Выполнено чтение по ссылке {link}");

                        _reportDataProgress.Report(new ReportDataDto
                        {
                            User = account.Login,
                            IpAddress = "111",
                            Operation = "Чтение",
                            Book = link,
                            SheetsCount = sheetsCount,
                            Status = nameof(OperationStatuses.Успешно)
                        });
                    }

                    await _litNetService.DisposeAsync();
                }
                else
                {
                    logger($"Неудачная попытка входа в аккаунт. Пользователь: {account.Login}, пароль: {account.Password}");
                    return;
                }

                await _litNetService.DisposeAsync();
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

            if (litNetSessionCounter > 0)
                _reportDataProgress.Report(new ReportDataDto
                {
                    Operation = "Конец сессии",
                    SessionDateTime = DateTime.Now
                });
        }
    }
}