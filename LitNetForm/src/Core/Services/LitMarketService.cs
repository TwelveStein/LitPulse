using Contracts.DTOs;
using Core.Abstracts;
using Core.Entities.ValueObjects;
using Core.Enums;
using Core.Settings;
using Microsoft.Playwright;

namespace Core.Services
{
    public sealed class LitMarketService : IBookService
    {
        private readonly ScrollModel _scrollModel;
        private readonly AccountHistoryService _accountHistoryService;

        private IPlaywright _playwright = null!;
        private IBrowser _browser = null!;
        private IBrowserContext _context = null!;
        private IPage _page = null!;

        public LitMarketService(ScrollModel scrollModel, AccountHistoryService accountHistoryService)
        {
            _scrollModel = scrollModel;
            _accountHistoryService = accountHistoryService;
        }

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

        public async Task<bool> Login(string login, string password, string linkLogin, Action<string> log)
        {
            try
            {
                if (_page == null)
                {
                    throw new InvalidOperationException(
                        "Playwright не инициализирован. Вызовите InitializeAsync() сначала.");
                }

                await _page.GotoAsync(linkLogin);
                await _page.ClickAsync(".login-btn");
                await _page.Locator("#email").FillAsync(login);
                await _page.Locator("#password").FillAsync(password);
                await _page.Keyboard.PressAsync("Enter");

                var isTextVisible = await _page.TextContentAsync("body").ContinueWith(t =>
                    t.Result?.Contains("Пользователь с таким имэйлом не зарегистрирован на портале") ?? false);

                /*var isTextVisiblePassword = await _page.TextContentAsync("body").ContinueWith(t =>
                t.Result?.Contains("Пароль неверный. Проверьте правильность ввода, убедитесь что \"caps lock\" не включен и язык ввода пароля верный.") ?? false);*/

                var isTextVisiblePassword = await _page.TextContentAsync("body").ContinueWith(t =>
                    t.Result?.Contains("Проверьте правильность ввода") ?? false);

                var timeout = await _page.TextContentAsync("body").ContinueWith(t =>
                    t.Result?.Contains(
                        "Превышен лимит запросов авторизации. следующая попытка разрешена через 15 минут.") ?? false);

                if (isTextVisible && !isTextVisiblePassword)
                {
                    //неправльный логин или пароль лог
                    // лог провожу попытку регистрации 
                    var checkRegistration = await _page.TextContentAsync("body").ContinueWith(t =>
                        t.Result?.Contains(
                            "Пользователь с таким имэйлом уже существует. Попробуйте авторизоваться вместо повторной регистрации") ??
                        false);

                    if (checkRegistration)
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
                else if (isTextVisiblePassword)
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
            catch (Exception)
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
        public async Task ReaderBooks(
            UserContextDto userContext,
            Guid sessionId,
            string bookLink,
            Action<string> log,
            StartupSettings startupSettings,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            await _page.GotoAsync(bookLink);

            var actions = new List<(SettingState settings, Func<Task> action)>
            {
                (startupSettings.LikeTheBook, async () =>
                    await LikeTheBookAsync(userContext, sessionId, bookLink, cancellationToken)),

                (startupSettings.AddToLibrary, async () =>
                    await AddToLibraryAsync(userContext, sessionId, bookLink, cancellationToken)),

                (startupSettings.ReadBook, async () =>
                    await ReadBookAsync(userContext, sessionId, bookLink, startupSettings.ReadProfile, log,
                        cancellationToken)),

                (startupSettings.SubscribeToTheAuthor, async () =>
                    await SubscribeToTheAuthorAsync(userContext, sessionId, bookLink, cancellationToken))
            };

            foreach (var item in actions
                         .Where(x => x.settings.Enabled)
                         .OrderBy(x => x.settings.Order))
            {
                await _page.WaitForTimeoutAsync(2000);
                await item.action();
            }

            await _page.WaitForTimeoutAsync(3000);
        }

        private async Task SubscribeToTheAuthorAsync(
            UserContextDto userContext,
            Guid sessionId,
            string bookLink,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var subscribeResult = await IsButtonClickable(".card-share__subscribe-button");
            if (subscribeResult)
            {
                ActionDto actionDto = new ActionDto(userContext, sessionId, bookLink);
                await _accountHistoryService.SaveActionSubscribeToTheAuthorAsync(actionDto, cancellationToken);
            }
        }

        private async Task LikeTheBookAsync(
            UserContextDto userContext,
            Guid sessionId,
            string bookLink,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var likeButton = await _page.QuerySelectorAsync("span.rating-like-label");
            if (likeButton != null)
            {
                try
                {
                    await _page.GetByRole(AriaRole.Button, new()
                        {
                            Name = "Нравится",
                        })
                        .ClickAsync();

                    // Записываем событие в БД
                    ActionDto actionDto = new ActionDto(userContext, sessionId, bookLink);
                    await _accountHistoryService.SaveActionLikeTheBookAsync(actionDto, cancellationToken);
                }
                catch
                {
                    // ignored
                }

                await _page.WaitForTimeoutAsync(3000);

                var likeBook = await _page.QuerySelectorAsync(".lmSimpleModal__close");
                if (likeBook != null)
                {
                    var box = await likeBook.BoundingBoxAsync();
                    await _page.Mouse.ClickAsync(box.X + 2, box.Y + 2);
                }
            }
        }

        private async Task AddToLibraryAsync(
            UserContextDto userContext,
            Guid sessionId,
            string linkBook,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            await _page.GotoAsync(linkBook);

            ActionDto actionDto = new ActionDto(userContext, sessionId, linkBook);
            bool inLibraryResult = await IsButtonClickable("a:has-text('В библиотеку')");
            if (inLibraryResult)
            {
                // Сохраняем событие в БД
                await _accountHistoryService.SaveActionToLibraryAsync(actionDto, cancellationToken);
            }

            bool toFavorites = await IsButtonClickable("button:has-text('Избранное')");
            if (toFavorites)
            {
                // Сохраняем событие в БД
                await _accountHistoryService.SaveActionToFavoriteAsync(actionDto, cancellationToken);
            }
        }

        private async Task ReadBookAsync(
            UserContextDto userContext,
            Guid sessionId,
            string link,
            ReadProfile readProfile,
            Action<string> log,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // Количество прочитанных страниц
            int sheetsCounter = 0;

            await _scrollModel.BrowseBookPageAsync(_page, log, cancellationToken);

            await _page.ClickAsync("div.btn-reader");

            await _page.WaitForTimeoutAsync(3000);

            //var buttonContinue = "div:has-text('Далее&nbsp;→')";

            try
            {
                while (true)
                {
                    var urlPage = _page.Url;
                    await _scrollModel.ReadPageAsync(_page, readProfile, log, cancellationToken);
                    sheetsCounter++;

                    var nextButton = await _page.QuerySelectorAsync("div.chapter-nav__right:has-text('Далее')");

                    if (nextButton != null && await nextButton.IsVisibleAsync())
                    {
                        // Нажатие на кнопку
                        await nextButton.ClickAsync();

                        await _page.WaitForTimeoutAsync(4500); // Пауза для полной загрузки
                        if (_page.Url == urlPage)
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
                }
            }
            catch (Exception)
            {
                // ignored
            }
            finally
            {
                if (sheetsCounter > 0)
                {
                    ReadActionDto readActionDto = new ReadActionDto(
                        userContext,
                        sessionId,
                        link,
                        sheetsCounter);

                    // Запись о прочитанных страницах, должна попасть в БД
                    await _accountHistoryService.SaveActionReadBookAsync(readActionDto);
                }
            }
        }

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

        private static void Log(Action<string>? cb, string m) =>
            cb?.Invoke($"[{DateTime.Now:HH:mm:ss.fff}] {m}");
    }
}