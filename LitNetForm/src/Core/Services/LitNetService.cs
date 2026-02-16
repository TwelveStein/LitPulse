using Contracts.DTOs;
using Core.Abstracts;
using Core.Entities.ValueObjects;
using Core.Enums;
using Core.Settings;
using Microsoft.Playwright;

namespace Core.Services
{
    public sealed class LitNetService : IBookService
    {
        private readonly AccountHistoryService _accountHistoryService;
        private readonly ScrollModel _scrollModel;
        
        private IPlaywright _playwright = null!;
        private IBrowser _browser = null!;
        private IBrowserContext _context = null!;
        private IPage _page = null!;

        public LitNetService(ScrollModel scrollModel, AccountHistoryService accountHistoryService)
        {
            _scrollModel = scrollModel;
            _accountHistoryService = accountHistoryService;
        }

        // Метод инициализации
        public async Task InitializeAsync()
        {
            var randomProxy = ProxysService.GetRandomProxy();

            _playwright = await Playwright.CreateAsync();
            if (randomProxy != null)
            {
                Proxy proxy = new Proxy
                {
                    Server = randomProxy.Server,
                    Username = randomProxy.Username,
                    Password = randomProxy.Password
                };

                _browser = await _playwright.Chromium.LaunchAsync(new()
                {
                    Channel = "chrome",
                    Headless = false,
                    SlowMo = 1000,
                    Args = new[]
                    {
                        "--start-maximized"
                    },
                    Proxy = proxy
                });
            }
            else
            {
                _browser = await _playwright.Chromium.LaunchAsync(new()
                {
                    Channel = "chrome",
                    Headless = false,
                    SlowMo = 1000,
                    Args = new[]
                {
                    "--start-maximized"
                }
                });
            }

            _context = await _browser.NewContextAsync(new()
            {
                ViewportSize = ViewportSize.NoViewport
            });

            _page = await _context.NewPageAsync();
        }

        /// <summary>
        /// Метод задания первичной активности для обхода reCapcha
        /// Требуется вставить несколько ссылок чтобы бот прошел и проявил на них немного активности
        /// </summary>
        /// <param name="url">Ссылка на страницы</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public async Task PrimaryActivity(
            string url,
            Action<string> log,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            try
            {
                if (_page == null)
                {
                    throw new InvalidOperationException(
                        "Playwright не инициализирован. Вызовите InitializeAsync() сначала.");
                }

                await _page.GotoAsync(url);
                await _page.GetByText("Добавить в библиотеку").ClickAsync();
                await _page.Mouse.ClickAsync(100, 100);
                await _scrollModel.BrowseBookPageAsync(_page, log, cancellationToken);
            }
            catch (PlaywrightException)
            {
            }
            catch (Exception)
            {
                // ignored
            }
        }

        /// <summary>
        /// Метод базовой активности бота 
        /// Открытие страниц. Добавление в библиотеку. Чтение книг.
        /// </summary>
        /// <param name="bookLink"></param>
        /// <returns></returns>
        public async Task BaseActivityBotAsync(
            UserContextDto userContext,
            Guid sessionId,
            string bookLink,
            Action<string> log,
            StartupSettings startupSettings,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            if (_page == null)
            {
                throw new InvalidOperationException(
                    "Playwright не инициализирован. Вызовите InitializeAsync() сначала.");
            }

            await _page.GotoAsync(bookLink);

            var actions = new List<(SettingState settings, Func<Task> action)>
            {
                (startupSettings.LikeTheBook, async () => 
                    await LikeTheBookAsync(userContext, sessionId, bookLink, cancellationToken)),
                
                (startupSettings.AddToLibrary, async () => 
                    await AddToLibraryAsync(userContext, sessionId, bookLink, cancellationToken)),
                
                (startupSettings.ReadBook, async () => 
                    await ReadBookAsync(userContext, sessionId, bookLink, startupSettings.ReadProfile, log, cancellationToken))
            };
            
            foreach (var item in actions
                         .Where(x => x.settings.Enabled)
                         .OrderBy(x => x.settings.Order))
            {
                await item.action();
            }
        }

        private async Task AddToLibraryAsync(
            UserContextDto userContext,
            Guid sessionId,
            string bookLink,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            try
            {
                var elements = await _page.QuerySelectorAllAsync("text=Добавить в библиотеку");
                if (elements.Count > 0)
                {
                    await _page.GetByText("Добавить в библиотеку").ClickAsync();

                    // Записываем событие в БД
                    ActionDto actionDto = new ActionDto(userContext, sessionId, bookLink);
                    await _accountHistoryService.SaveActionToLibraryAsync(actionDto, cancellationToken);
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private async Task LikeTheBookAsync(
            UserContextDto userContext,
            Guid sessionId,
            string bookLink,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            try
            {
                await _page.ClickAsync(
                    "a.rate-btn.rate-btn-like",
                    new PageClickOptions { Timeout = 4000 });

                // Записываем событие в БД
                ActionDto actionDto = new ActionDto(userContext, sessionId, bookLink);
                await _accountHistoryService.SaveActionLikeTheBookAsync(actionDto, cancellationToken);
            }
            catch
            {
                // ignored
            }
            await _page.WaitForTimeoutAsync(2000);
        }

        private async Task ReadBookAsync(
            UserContextDto userContext,
            Guid sessionId,
            string bookLink,
            ReadProfile readProfile,
            Action<string> log,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            
            // Количество прочитанных страниц
            int sheetsCounter = 0;
            
            await _scrollModel.BrowseBookPageAsync(_page, log, cancellationToken);
            
            var locatorLearn = _page
                .GetByRole(AriaRole.Link, new PageGetByRoleOptions { Name = "Читать", Exact = true })
                .CountAsync();

            if (locatorLearn.Result > 0)
            {
                await _page
                    .GetByRole(AriaRole.Link, new PageGetByRoleOptions { Name = "Читать", Exact = true })
                    .ClickAsync();
            }
            else
            {
                await _page
                    .GetByRole(AriaRole.Link, new PageGetByRoleOptions { Name = "Продолжить чтение", Exact = true })
                    .ClickAsync();
            }

            try
            {
                while (true)
                {
                    var nextButton1 = await _page.QuerySelectorAsync("a.pull-right:has-text('Вперед')");
                    var nextButton2 = await _page.QuerySelectorAsync("a.pull-right:has-text('След. часть')");

                    if ((nextButton1 != null || nextButton2 != null) &&
                        await _page.Locator("#link-right").CountAsync() > 0)
                    {
                        await _scrollModel.ReadPageAsync(_page, readProfile, log, cancellationToken);

                        await _page.ClickAsync("#link-right");

                        sheetsCounter++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            finally
            {
                if (sheetsCounter > 0)
                {
                    // Запись о прочитанных страницах, должна попасть в БД
                    ReadActionDto actionDto = new ReadActionDto(userContext, sessionId, bookLink, sheetsCounter);
                    await _accountHistoryService.SaveActionReadBookAsync(actionDto);
                }
            }
        }

        public async Task<bool> Login(string login, string password, string linkLogin)
        {
            if (_page == null)
            {
                throw new InvalidOperationException(
                    "Playwright не инициализирован. Вызовите InitializeAsync() сначала.");
            }

            await _page.GotoAsync(linkLogin);
            await _page.Mouse.ClickAsync(100, 100);
            await _page.GetByLabel("Телефон или Email").FillAsync(login);
            await _page.GetByLabel("Пароль").FillAsync(password);
            await _page.Keyboard.PressAsync("Enter");
            await _page.WaitForTimeoutAsync(3000);
            if (_page.Url == linkLogin)
            {
                return false;
            }

            return true;
        }

        // Метод для очистки ресурсов (не забудьте вызывать его при завершении)
        public async ValueTask DisposeAsync()
        {
            if (_browser != null)
            {
                await _page.CloseAsync();
                await _context.CloseAsync();
                await _browser.CloseAsync();
            }
            _playwright?.Dispose();
        }
    }
}