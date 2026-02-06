using Core.Enums;
using Microsoft.Playwright;

namespace Core.Services;

/// <summary>
/// Универсальный скролл-ридер для LitNet и LitMarket.
/// Поддерживает чтение глав и ознакомление со страницей книги.
/// </summary>
public sealed class ScrollModel
{
    public async Task ReadPageAsync(
        IPage page,
        ReadProfile readProfile,
        Action<string>? log,
        CancellationToken ct)
    {
        await ReadPageCoreAsync(page, readProfile, log, ct);
    }
    
    public async Task BrowseBookPageAsync(
        IPage page,
        Action<string>? log,
        CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        
        if (page == null) throw new ArgumentNullException(nameof(page));

        var rnd = new Random();
        await Task.Delay(1000 + rnd.Next(800), cancellationToken);
        Log(log, "[INFO] Начало ознакомления со страницей книги");

        // === 1. ГОЛОВА ===
        Log(log, "→ Этап 1: Голова — изучение шапки");
        await Task.Delay(4000 + rnd.Next(2000), cancellationToken);

        // === 2. ТЕЛО: карусель «С этой книгой читают» ===
        Log(log, "→ Этап 2: Тело — листание карусели (3–5 раз)");

        int clicks = 0;
        int maxClicks = rnd.Next(1, 5);
        string carusSel = "#comments, .comments, .comment-list, .jsComment, .widget-block";
        while (clicks < maxClicks && !cancellationToken.IsCancellationRequested)
        {
            try
            {
                // Ищем кнопку стрелки → (LitMarket: внутри .lmButton_arrowRight)
                await Task.Delay(800 + rnd.Next(700), cancellationToken);
                await ScrollTo(page, carusSel, 900, cancellationToken);
                await page.WaitForTimeoutAsync(1000);

                var elem = await page.QuerySelectorAsync(".lmfont-arrow-right, .bx-next");
                if (elem == null)
                {
                    Log(log, "  → Кнопка карусели не найдена — завершаем");
                    break;
                }

                var box = await elem.BoundingBoxAsync();
                if (box == null)
                {
                    Log(log, "  → Кнопка не в DOM — завершаем");
                    break;
                }
      
                // Имитация движения мыши + задержка + клик (как человек)
                await page.Mouse.MoveAsync(box.X + box.Width / 2, box.Y + box.Height / 2);
                await page.Mouse.ClickAsync(box.X + box.Width / 2, box.Y + box.Height / 2);

                clicks++;
                Log(log, $"  → Листнул карусель ({clicks}/{maxClicks})");
            }
            catch (PlaywrightException ex)
            {
                Log(log, $"    → Карусель закончена: {ex.Message}");
                break;
            }
        }

        // === 3. ПОДВАЛ: комментарии ===
        Log(log, "→ Этап 3: Подвал — вдумчивое чтение комментариев");
        string commentsSel = ".made-in-russia, .main_footer-inform-title";
        try
        {
            await ScrollTo(page, commentsSel, 15000, cancellationToken);
            await Task.Delay(1500 + rnd.Next(1000), cancellationToken);
        }
        catch (PlaywrightException ex)
        {
            Log(log, "Страница браузера закрыта!");
        }


        // === 4. ВОЗВРАТ В ГОЛОВУ ===
        Log(log, "→ Этап 4: Возврат в начало");
        try
        {
            await SmoothScrollTo(page, 0, 2000, cancellationToken);
            await Task.Delay(1000, cancellationToken);
        }
        catch (PlaywrightException ex)
        {
            Log(log, "Страница браузера закрыта!");
        }

        Log(log, "[OK] Ознакомление завершено (2–3 мин)");
    }

    // ────────────────────────────────────────────────────────
    // ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ
    // ────────────────────────────────────────────────────────

    private async Task ReadPageCoreAsync(
        IPage page, 
        ReadProfile readProfile, 
        Action<string>? log, 
        CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        
        string url = await page.EvaluateAsync<string>("() => location.href");
        bool isLitNet = url.Contains("litnet.com");
        bool isLitMarket = url.Contains("litmarket.ru");

        if (isLitNet)
        {
            Log(log, "[INFO] LitNet: чтение главы");
            await ReadLitNetAsync(page, readProfile, log, cancellationToken);
        }
        else if (isLitMarket)
        {
            Log(log, "[INFO] LitMarket: чтение главы");
            await ReadLitMarketAsync(page, readProfile, log, cancellationToken);
        }
        else
        {
            Log(log, "[WARN] Неизвестная платформа — fallback");
            int maxScroll = await page.EvaluateAsync<int>("() => document.body.scrollHeight - window.innerHeight");
            await ScrollTargetAsync(page, readProfile, maxScroll, "window", log, cancellationToken);
        }
    }

    private async Task ReadLitNetAsync(
        IPage page, 
        ReadProfile readProfile, 
        Action<string>? log, 
        CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        
        int lastScrollHeight = await page.EvaluateAsync<int>("() => document.body.scrollHeight");
        int currentPage = 1;

        while (!cancellationToken.IsCancellationRequested)
        {
            int maxScroll = await page.EvaluateAsync<int>("() => document.body.scrollHeight - window.innerHeight");
            await ScrollTargetAsync(page, readProfile, maxScroll, "window", log, cancellationToken);

            currentPage++;
            await page.EvaluateAsync($"() => {{ if (typeof Reader !== 'undefined' && Reader.goTo) Reader.goTo({currentPage}); }}");

            try
            {
                await page.WaitForFunctionAsync(@"
                    ([prev]) => Math.abs(document.body.scrollHeight - prev) > 100",
                    new object[] { lastScrollHeight }, new PageWaitForFunctionOptions { Timeout = 5000 });
            }
            catch { break; }

            int newScrollHeight = await page.EvaluateAsync<int>("() => document.body.scrollHeight");
            if (newScrollHeight - lastScrollHeight < 100) break;
            lastScrollHeight = newScrollHeight;
            await Task.Delay(500, cancellationToken);
        }
    }

    private async Task ReadLitMarketAsync(
        IPage page,
        ReadProfile readProfile, 
        Action<string>? log, 
        CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        
        await page.WaitForSelectorAsync(".frame-content", new PageWaitForSelectorOptions { Timeout = 8000 });
        await page.WaitForFunctionAsync(@"() => document.querySelector('.frame-content p')",
            new PageWaitForFunctionOptions { Timeout = 5000 });

        var paras = await page.EvaluateAsync<string[]>(@"
            () => Array.from(document.querySelectorAll('.frame-content p'))
                .map(p => p.innerText.trim()).filter(t => t.length > 5)");

        var rnd = new Random();
        double fatigue = 1.0;
        for (int i = 0; i < paras.Length && !cancellationToken.IsCancellationRequested; i++)
        {
            if (i > 0 && rnd.NextDouble() < 0.12)
            {
                int to = Math.Max(0, i - 1);
                await ScrollToParagraph(page, to, 100, cancellationToken);
                await Task.Delay(100 + rnd.Next(100), cancellationToken);
                i = Math.Max(0, i - 2);
                continue;
            }

            int dur = 200 + rnd.Next(50) * (int)(readProfile == ReadProfile.TiredReader ? fatigue : 1.0);
            await ScrollToParagraph(page, i, dur, cancellationToken);

            int pause = 200 + rnd.Next(150) * (int)(readProfile == ReadProfile.TiredReader ? fatigue : 1.0);
            await Task.Delay(pause, cancellationToken);

            if (readProfile == ReadProfile.TiredReader)
                fatigue = 1.0 + Math.Log(1 + i * 0.12);
        }
    }

    private async Task ScrollTargetAsync(
        IPage page, 
        ReadProfile readProfile, 
        int maxScroll, 
        string mode,
        Action<string>? log, 
        CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        
        if (maxScroll <= 0) maxScroll = 500;
        var rnd = new Random();
        int pos = 0;

        while (pos < maxScroll && !cancellationToken.IsCancellationRequested)
        {
            if (pos > 300 && rnd.NextDouble() < (readProfile switch
                {
                    ReadProfile.DeepReader => 0.20,
                    ReadProfile.TiredReader => 0.12,
                    _ => 0.03
                }))
            {
                int to = Math.Max(100, pos - rnd.Next(80, 200));
                await SmoothScrollTo(page, to, 800, cancellationToken);
                await Task.Delay(500 + rnd.Next(400), cancellationToken);
                pos = to;
                continue;
            }

            int step = readProfile switch
            {
                ReadProfile.DeepReader => 200 + rnd.Next(80),
                ReadProfile.SpeedReader => 350 + rnd.Next(120),
                _ => 280 + rnd.Next(100)
            };
            int next = Math.Min(pos + step, maxScroll);

            int dur = readProfile switch
            {
                ReadProfile.DeepReader => 1600 + rnd.Next(800),
                ReadProfile.SpeedReader => 600 + rnd.Next(300),
                _ => 1000 + rnd.Next(500)
            };
            await SmoothScrollTo(page, next, dur, cancellationToken);

            int pause = readProfile switch
            {
                ReadProfile.DeepReader => 1800 + rnd.Next(1200),
                ReadProfile.SpeedReader => 400 + rnd.Next(250),
                _ => 900 + rnd.Next(750)
            };
            await Task.Delay(pause, cancellationToken);
            pos = next;
        }
    }

    private async Task ScrollToParagraph(
        IPage page,
        int index, 
        int ms, 
        CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        
        await page.EvaluateAsync(@"
            ([i, ms]) => new Promise(r => {
                const fc = document.querySelector('.frame-content');
                if (!fc) return r();
                const p = fc.querySelectorAll('p')[i];
                if (!p) return r();
                p.scrollIntoView({ block: 'center', behavior: 'smooth' });
                const t0 = performance.now();
                (function w() {
                    performance.now() - t0 > ms ? r() : requestAnimationFrame(w);
                })();
            })", new object[] { index, ms });
        await Task.Delay(50, cancellationToken);
    }

    private async Task SmoothScrollTo(IPage page, int targetY, int ms, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        
        await page.EvaluateAsync(@"
            ([y, ms]) => new Promise(r => {
                const s = window.scrollY;
                const d = y - s;
                const t0 = performance.now();
                (function a(t1) {
                    const t = Math.min((t1 - t0) / ms, 1);
                    const k = t * t * (3 - 2 * t);
                    window.scrollTo(0, s + d * k);
                    t < 1 ? requestAnimationFrame(a) : r();
                })(performance.now());
            })", new object[] { targetY, ms });
        await Task.Delay(50, cancellationToken);
    }

    private async Task<bool> IsElementVisible(IPage page, string sel)
    {
        try { return await page.EvaluateAsync<bool>($"() => !!document.querySelector('{sel}')"); }
        catch { return false; }
    }

    private async Task ScrollTo(IPage page, string sel, int dur, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        
        try
        {
            int top = await page.EvaluateAsync<int>($@"
                () => {{
                    const el = document.querySelector('{sel}');
                    return el ? el.getBoundingClientRect().top + window.scrollY - 80 : window.scrollY;
                }}");
            if (top > 0) await SmoothScrollTo(page, top, dur, cancellationToken);
        }
        catch (PlaywrightException ex)
        {
            
        }
    }

    private void Log(Action<string>? cb, string m) =>
        cb?.Invoke($"[{DateTime.Now:HH:mm:ss.fff}] {m}");
}