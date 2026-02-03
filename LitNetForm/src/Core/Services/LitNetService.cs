using Contracts.Enums;
using Core.Abstracts;
using Core.Manager;
using Microsoft.Playwright;

namespace Core.Services
{
    public sealed class LitNetService : IBookService
    {
        private readonly ServiceManager _serviceManager;
        
        private IPlaywright _playwright;
        private IBrowser _browser;
        private IBrowserContext _context;
        private IPage _page;
        private CancellationTokenSource? _cts;

        // Метод инициализации
        public LitNetService(ServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public async Task InitializeAsync()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new()
            {
                Channel = "chrome",
                Headless = false,
                SlowMo = 1000,
                Args = new string[]
                 {
                     "--start-maximized"
                 }
            });

            _context = await _browser.NewContextAsync(new()
            {
                ViewportSize = ViewportSize.NoViewport
            });
            
            /*var context = await _browser.NewContextAsync(new()
            {
                ViewportSize = ViewportSize.NoViewport
            });*/

            _page = await _context.NewPageAsync();
            
            _serviceManager.RegisterService(this);
        }

        /// <summary>
        ///Метод задания первичной активности для обхода reCapcha
        ///Требуется вставить несколько ссылок чтобы бот прошел и проявил на них немного активности
        /// </summary>
        /// <param name="url">Ссылка на старницы</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public async Task PrimaryActivity(string url, Action<string> log)
        {
            try
            {
                if (_page == null)
                {
                    throw new InvalidOperationException(
                        "Playwright не инициализирован. Вызовите InitializeAsync() сначала.");
                }

                _cts = new CancellationTokenSource();
                var token = _cts.Token;

                await _page.GotoAsync(url);
                await _page.GetByText("Добавить в библиотеку").ClickAsync();
                await _page.Mouse.ClickAsync(100, 100);
                await ScrollModel.BrowseBookPageAsync(_page, log, token);
            }
            catch (PlaywrightException ex)
            {
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Метод базовай активности бота 
        /// Открытие страниц . добавление в библиотеку, чтение книг
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<int> BaseActivityBot(string url, Action<string> log, ReadProfile readProfile, Settings.StartupSettings startupSettings)
        {
            int sheetsCounter = 0;
            
            if (_page == null)
            {
                throw new InvalidOperationException("Playwright не инициализирован. Вызовите InitializeAsync() сначала.");
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
                    await _page.ClickAsync("a.rate-btn.rate-btn-like" , new() { Timeout = 4000 });
                }
                catch { }
                await _page.WaitForTimeoutAsync(2000);
            }
            _cts = new CancellationTokenSource();
            var token = _cts.Token;
            await ScrollModel.BrowseBookPageAsync(_page, log, token);
            if (startupSettings.ReadBook) 
            {
                var locator_learn = _page.GetByRole(AriaRole.Link, new() { Name = "Читать", Exact = true }).CountAsync();
                if (locator_learn.Result > 0)
                {
                    await _page.GetByRole(AriaRole.Link, new() { Name = "Читать", Exact = true }).ClickAsync();
                }
                else
                {
                    await _page.GetByRole(AriaRole.Link, new() { Name = "Продолжить чтение", Exact = true }).ClickAsync();
                }
                
                string url_page_book;
                while (true)
                {
                    url_page_book = _page.Url;

                    var nextButton1 = await _page.QuerySelectorAsync("a.pull-right:has-text('Вперед')");
                    var nextButton2 = await _page.QuerySelectorAsync("a.pull-right:has-text('След. часть')");

                    if ((nextButton1 != null || nextButton2 != null) && await _page.Locator("#link-right").CountAsync() > 0)
                    {

                        await ScrollModel.ReadPageAsync(_page, readProfile, log, token);

                        await _page.ClickAsync("#link-right");
                        
                        sheetsCounter++;
                    }
                    else { break; }
                    
                    return sheetsCounter;
                }
            }

            return sheetsCounter;
        }

        public async Task<bool> Login(string login, string password, string Link_login)
        {
            if (_page == null)
            {
                throw new InvalidOperationException("Playwright не инициализирован. Вызовите InitializeAsync() сначала.");
            }

            await _page.GotoAsync(Link_login);
            await _page.Mouse.ClickAsync(100, 100);
            await _page.GetByLabel("Телефон или Email").FillAsync(login);
            await _page.GetByLabel("Пароль").FillAsync(password);
            await _page.Keyboard.PressAsync("Enter");
            await _page.WaitForTimeoutAsync(3000);
            if (_page.Url == Link_login)
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
                //await _browser.DisposeAsync();
            }
            _playwright?.Dispose();
        }
    }
}