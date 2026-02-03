using Contracts.DTOs;
using Contracts.Enums;
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
    private readonly IProgress<ReportDataDto> _reportDataProgress;

    public StartLitMarketHandler(
        LitMarketService litMarketService,
        IProgress<ReportDataDto> reportDataProgress)
    {
        _litMarketService = litMarketService;
        _reportDataProgress = reportDataProgress;
    }

    /// <summary>
    /// Старт обработчика LitMarket
    /// </summary>
    public async Task HandleAsync(
        Account account,
        string[] litMarketLinks,
        Action<string> logger,
        CancellationToken cancellationToken)
    {
        int litMarketSessionCounter = 0;

        try
        {
            if (litMarketLinks.Length != 0)
            {
                logger("Запуск эмуляции чтения https://litmarket.ru/ ...");

                await _litMarketService.InitializeAsync();

                _reportDataProgress.Report(new ReportDataDto
                {
                    Operation = "Начало сессии",
                    SessionDateTime = DateTime.Now
                });

                litMarketSessionCounter++;

                if (await _litMarketService.Login(
                        account.Login,
                        account.Password,
                        LIT_MARKET_LINK_LOGIN,
                        logger))
                {
                    logger($"Выполнен вход в аккаунт {account.Login}");

                    foreach (string link in litMarketLinks)
                    {
                        int sheetsCount = await _litMarketService.ReaderBooks(
                            link,
                            logger,
                            account.AccountSettings.ReadProfile,
                            new StartupSettings(account.AccountSettings),
                            cancellationToken);

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

                    //await _litMarketService.DisposeAsync();
                }
                else
                {
                    logger($"Неудачная попытка входа в аккаунт. Пользователь: {account.Login}, пароль: {account.Password}");
                }

                //await _litMarketService.DisposeAsync();
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
            //await _litMarketService.DisposeAsync();
            if (litMarketSessionCounter > 0)
                _reportDataProgress.Report(new ReportDataDto
                {
                    Operation = "Конец сессии",
                    SessionDateTime = DateTime.Now
                });
        }
    }
}