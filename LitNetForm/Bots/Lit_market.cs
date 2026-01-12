using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Scroll_model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace net_market_bot
{
    class Lit_market
    {
        private IPlaywright _playwright;
        private IBrowser _browser;
        private IPage _page;
        private CancellationTokenSource? _cts;

        /// <summary>
        /// Метод инициализации playwright
        /// </summary>
        /// <returns></returns>
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
        ///  Метод деинициализации программы
        /// </summary>
        /// <returns></returns>
        public async Task DisposeAsync()
        {
            if (_browser != null)
            {
                await _browser.DisposeAsync();
                await _browser.CloseAsync();
            }
            _playwright?.Dispose();
        }

        public async Task<bool> Login(string login, string password, string Link_login, Action<string> log)
        {
            try
            {
                if (_page == null)
                {
                    throw new InvalidOperationException("Playwright не инициализирован. Вызовите InitializeAsync() сначала.");
                }

                await _page.GotoAsync(Link_login);
                await _page.ClickAsync(".login-btn");
                await _page.Locator("#email").FillAsync(login);
                await _page.Locator("#password").FillAsync(password);
                await _page.Keyboard.PressAsync("Enter");
                var isTextVisible = await _page.TextContentAsync("body").ContinueWith(t =>
                t.Result?.Contains("Пользователь с таким имэйлом не зарегистрирован на портале") ?? false);
                var isTextVisible_password = await _page.TextContentAsync("body").ContinueWith(t =>
                t.Result?.Contains("Пароль неверный. Проверьте правильность ввода, убедитесь что \"caps lock\" не включен и язык ввода пароля верный. ") ?? false);
                var timeout = await _page.TextContentAsync("body").ContinueWith(t =>
                t.Result?.Contains("Превышен лимит запросов авторизации. следующая попытка разрешена через 15 минут.") ?? false);
                if (isTextVisible && !isTextVisible_password)
                {
                    //неправльный логин или пароль лог
                    // лог провожу попытку регистрации 
                    var check_regist = await _page.TextContentAsync("body").ContinueWith(t =>
                    t.Result?.Contains("Пользователь с таким имэйлом уже существует. Попробуйте авторизоваться вместо повторной регистрации") ?? false);


                    if (check_regist)
                    {
                        Log(log, "[X] Регистрация не удалась");
                    }
                    else
                    {

                        await _page.WaitForTimeoutAsync(5000);
                        await _page.GetByRole(AriaRole.Button, new() { Name = "Регистрация" }).ClickAsync();
                        // 2. Найдите и установите флажок "Я согласен с..." (eula_agree)
                        // Используем ID для более точного выбора.
                        await _page.WaitForTimeoutAsync(5000);
                        var elem = await _page.QuerySelectorAsync("#eula_agree");
                        var box = await elem.BoundingBoxAsync();
                        await _page.Mouse.ClickAsync((box.X + 5), (box.Y + 5));

                        // 3. Найдите и установите флажок "Мне уже исполнилось 18" (eula_18_years)
                        // Используем ID для более точного выбора.
                        elem = await _page.QuerySelectorAsync("#eula_18_years");
                        box = await elem.BoundingBoxAsync();
                        await _page.Mouse.ClickAsync((box.X + 5), (box.Y + 5));


                        // 4. Найдите и нажмите кнопку "Подтвердить" (approve_role)
                        // Используем ID для более точного выбора.
                        await _page.ClickAsync("#approve_role");

                        // 5. (Опционально) Добавьте ожидание, чтобы увидеть результат действия (например, закрытие модального окна или переход).
                        // Ожидаем, что элемент '.card' больше не будет виден (модальное окно закрылось).

                        return true;
                    }
                }
                else if (isTextVisible_password)
                {
                    Log(log, $"[WARN] У аккаунта {login} не верный пароль");
                    return false;
                }
                else if (timeout) 
                {
                    Log(log, $"[WARN] Сайтом установлен 15ти минутный таймаут на вход");
                    return false;
                }

                Log(log, $"[INFO] Вход в аккаунт {login} выполнен успешно");

                return true;

            }
            catch(Exception ex)
            {
                return false;
            }

        }

        /// <summary>
        /// Метод проверки кнопки на кликабельность
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        public async Task<bool> IsButtonClickable(string selector, int timeout = 5000)
        {
            try
            {
                await _page.ClickAsync(selector, new PageClickOptions
                {
                    Timeout = timeout
                });
                return true;
            }
            catch (TimeoutException)
            {
                Console.WriteLine($"Кнопка {selector} не кликабельна (таймаут)");
                return false;
            }
        }

        /// <summary>
        /// Метод прохода по ссылкам 
        /// </summary>
        /// <returns></returns>
        public async Task<int> Reader_books(string link, Action<string> log, Scroll_model.Profile profile , LitNetForm.Settings.Settings settings) 
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;
            await _page.GotoAsync(link);
            await _page.WaitForTimeoutAsync(2000);
            await Scroll_model.BrowseBookPageAsync(_page, log, token);
            
            if (settings.ReadBook) 
            {
                int sheetsCounter = 0; 
                
                await _page.ClickAsync("div.btn-reader");

                await _page.WaitForTimeoutAsync(3000);
                var button_continue = "div:has-text('Далее&nbsp;→')";

                try {

                    while (true)
                    {
                        var url_page = _page.Url;
                        await Scroll_model.ReadPageAsync(_page, profile, log, token);
                        sheetsCounter++;

                        var nextButton = await _page.QuerySelectorAsync("div.chapter-nav__right:has-text('Далее')");

                        if (nextButton != null && await nextButton.IsVisibleAsync())
                        {

                            // Нажатие на кнопку
                            await nextButton.ClickAsync();

                            await _page.WaitForTimeoutAsync(4500); // Пауза для полной загрузки
                            if (_page.Url == url_page) 
                            {
                                break;
                            }
                                // Ожидание загрузки
                                await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);

                        }
                        else
                        {
                            break;
                        }

                        // Прокрутка к кнопке для гарантии видимости

                    } 
                    
                    return sheetsCounter;
                }
                catch { }

            }
            await _page.GotoAsync(link);
            if (settings.AddToLibrary) 
            {
                await IsButtonClickable("a:has-text('В библиотеку')");
                await IsButtonClickable("button:has-text('Избранное')");
            
            }
            if (settings.LikeTheBook) 
            {

                var Like_button = await _page.QuerySelectorAsync("span.rating-like-label");

                if (Like_button != null) 
                {
                        try 
                        {
                            await _page.GetByRole(AriaRole.Button, new() 
                            {
                                Name = "Нравится", 
                           
                            }).ClickAsync();
                    
                        }
                        catch { }

                    await _page.WaitForTimeoutAsync(3000);
                    var like_book = await _page.QuerySelectorAsync(".lmSimpleModal__close");
                    if (like_book != null) 
                    {

                        var box = await like_book.BoundingBoxAsync();
                        await _page.Mouse.ClickAsync(box.X + 2,box.Y + 2 );
                
                    }
                
                }
            }
            if (settings.SubscribeToTheAuthor) 
            {
                await IsButtonClickable(".card-share__subscribe-button");

            }
            await _page.WaitForTimeoutAsync(3000);

            return 0;
        }

        private static void Log(Action<string>? cb, string m) =>
        cb?.Invoke($"[{DateTime.Now:HH:mm:ss.fff}] {m}");
    }
}
