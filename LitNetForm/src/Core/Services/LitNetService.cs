using Contracts.Enums;
using Core.Abstracts;
using Core.Settings;
using Microsoft.Playwright;

namespace Core.Services
{
    public sealed class LitNetService : IBookService
    {
        private IPlaywright _playwright = null!;
        private IBrowser _browser = null!;
        private IBrowserContext _context = null!;
        private IPage _page = null!;

        // Метод инициализации
        public async Task InitializeAsync()
        {
            _playwright = await Playwright.CreateAsync();
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
                await ScrollModel.BrowseBookPageAsync(_page, log, cancellationToken);
            }
            catch (PlaywrightException ex)
            {
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        /// <summary>
        /// Метод базовой активности бота 
        /// Открытие страниц. Добавление в библиотеку. Чтение книг.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<int> BaseActivityBot(
            string url,
            Action<string> log,
            StartupSettings startupSettings,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            int sheetsCounter = 0;

            if (_page == null)
            {
                throw new InvalidOperationException(
                    "Playwright не инициализирован. Вызовите InitializeAsync() сначала.");
            }

            await _page.GotoAsync(url);
            var elements = await _page.QuerySelectorAllAsync("text=Добавить в библиотеку");
            if (elements.Count > 0 && startupSettings.AddToLibrary)
            {
                await _page.GetByText("Добавить в библиотеку").ClickAsync();
            }

            if (startupSettings.LikeTheBook)
            {
                try
                {
                    await _page.ClickAsync("a.rate-btn.rate-btn-like", new() { Timeout = 4000 });
                }
                catch
                {
                    // ignored
                }

                await _page.WaitForTimeoutAsync(2000);
            }

            //var token = _cts.Token;
            await ScrollModel.BrowseBookPageAsync(_page, log, cancellationToken);
            if (startupSettings.ReadBook)
            {
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
                    await _page.
                        GetByRole(AriaRole.Link, new PageGetByRoleOptions { Name = "Продолжить чтение", Exact = true })
                        .ClickAsync();
                }

                while (true)
                {
                    var nextButton1 = await _page.QuerySelectorAsync("a.pull-right:has-text('Вперед')");
                    var nextButton2 = await _page.QuerySelectorAsync("a.pull-right:has-text('След. часть')");

                    if ((nextButton1 != null || nextButton2 != null) &&
                        await _page.Locator("#link-right").CountAsync() > 0)
                    {
                        await ScrollModel.ReadPageAsync(_page, startupSettings.ReadProfile, log, cancellationToken);

                        await _page.ClickAsync("#link-right");

                        sheetsCounter++;
                    }
                    else
                    {
                        break;
                    }
                    return sheetsCounter;
                }
            }
            return sheetsCounter;
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