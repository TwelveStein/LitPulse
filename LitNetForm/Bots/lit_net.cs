using LitNetForm;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lit_net_bot_test
{
    public class PlaywrightService_for_litnet
    {
        private IPlaywright _playwright;
        private IBrowser _browser;
        private IPage _page;
        private CancellationTokenSource? _cts;

        // Метод инициализации
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

            var context = await _browser.NewContextAsync(new()
            {
                ViewportSize = ViewportSize.NoViewport
            });

            _page = await context.NewPageAsync();
        }

        /// <summary>
        ///Метод задания первичной активности для обхода reCapcha
        ///Требуется вставить несколько ссылок чтобы бот прошел и проявил на них немного активности
        /// </summary>
        /// <param name="url">Ссылка на старницы</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public async Task Primary_activity(string url, Action<string> log)
        {
            try
            {
                if (_page == null)
                {
                    throw new InvalidOperationException("Playwright не инициализирован. Вызовите InitializeAsync() сначала.");
                }

                await _page.GotoAsync(url);
                await _page.GetByText("Добавить в библиотеку").ClickAsync();
                await _page.Mouse.ClickAsync(100, 100);


                _cts = new CancellationTokenSource();
                var token = _cts.Token;
                await Scroll_model.ReadPageAsync(_page, Scroll_model.Profile.SpeedReader, log, token);
            }
            catch (Exception ex){}
           
        }

        /// <summary>
        /// Метод базовай активности бота 
        /// Открытие страниц . добавление в библиотеку, чтение книг
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task Base_Activuty_bot(string url, Action<string> log, Scroll_model.Profile profile)
        {

            if (_page == null)
            {
                throw new InvalidOperationException("Playwright не инициализирован. Вызовите InitializeAsync() сначала.");
            }
            await _page.GotoAsync(url);
            var elements = await _page.QuerySelectorAllAsync("text=Добавить в библиотеку");
            if (elements.Count > 0)
            {
                await _page.GetByText("Добавить в библиотеку").ClickAsync();
            }

            var locator_learn = _page.GetByRole(AriaRole.Link, new() { Name = "Читать", Exact = true }).CountAsync();
            if (locator_learn.Result > 0)
            {
                await _page.GetByRole(AriaRole.Link, new() { Name = "Читать", Exact = true }).ClickAsync();
            }
            else
            {
                await _page.GetByRole(AriaRole.Link, new() { Name = "Продолжить чтение", Exact = true }).ClickAsync();
            }
            _cts = new CancellationTokenSource();
            var token = _cts.Token;
            string url_page_book;
            while (true)
            {
                url_page_book = _page.Url;

                var nextButton1 = await _page.QuerySelectorAsync("a.pull-right:has-text('Вперед')");
                var nextButton2 = await _page.QuerySelectorAsync("a.pull-right:has-text('След. часть')");

                if ((nextButton1 != null || nextButton2 != null) && await _page.Locator("#link-right").CountAsync() > 0)
                {

                    await Scroll_model.ReadPageAsync(_page, profile, log, token);

                    await _page.ClickAsync("#link-right");

                }
                else { break; }
            }
        }

        public async Task Login(string login, string password, string Link_login)
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
                // ЛОГИ ПО КАПЧЕ
                await _page.WaitForTimeoutAsync(40000);
            }
        }

        // Метод для очистки ресурсов (не забудьте вызывать его при завершении)
        public async Task DisposeAsync()
        {
            if (_browser != null)
            {
                await _browser.DisposeAsync();
                await _browser.CloseAsync();
            }
            _playwright?.Dispose();
        }

    }
}