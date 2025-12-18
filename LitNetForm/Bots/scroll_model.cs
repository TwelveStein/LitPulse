using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Playwright;

/// <summary>
/// Универсальный скролл-ридер для LitNet и LitMarket.
/// Поддерживает чтение глав и ознакомление со страницей книги.
/// </summary>
public static class Scroll_model
{
    public enum Profile
    {
        DeepReader,
        SpeedReader,
        TiredReader
    }

    public static async Task ReadPageAsync(
        IPage page,
        Profile profile,
        Action<string>? log = null,
        CancellationToken ct = default)
    {
        await ReadPageCoreAsync(page, profile, log, ct);
    }

    public static async Task ReadPageAsync(
        IPage page,
        CancellationToken ct = default)
    {
        await ReadPageCoreAsync(page, Profile.TiredReader, null, ct);
    }

    public static async Task BrowseBookPageAsync(
        IPage page,
        Action<string>? log = null,
        CancellationToken ct = default)
    {
        if (page == null) throw new ArgumentNullException(nameof(page));

        var rnd = new Random();
        await Task.Delay(1000 + rnd.Next(800), ct);
        Log(log, "[INFO] Начало ознакомления со страницей книги");

        // === 1. ГОЛОВА ===
        Log(log, "→ Этап 1: Голова — изучение шапки");
        await Task.Delay(4000 + rnd.Next(2000), ct);

        // === 2. ТЕЛО: карусель «С этой книгой читают» ===
        Log(log, "→ Этап 2: Тело — листание карусели (3–5 раз)");

        int clicks = 0;
        int maxClicks = rnd.Next(1, 5);
        string carusSel = "#comments, .comments, .comment-list, .jsComment, .widget-block";
        while (clicks < maxClicks && !ct.IsCancellationRequested)
        {
            try
            {
                // Ищем кнопку стрелки → (LitMarket: внутри .lmButton_arrowRight)
                await Task.Delay(800 + rnd.Next(700), ct);
                await ScrollTo(page, carusSel, 900, ct);
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
            catch (Exception ex)
            {
                Log(log, $"    → Карусель закончена: {ex.Message}");
                break;
            }
        }

        // === 3. ПОДВАЛ: комментарии ===
        Log(log, "→ Этап 3: Подвал — вдумчивое чтение комментариев");
        string commentsSel = ".made-in-russia, .main_footer-inform-title";
        await ScrollTo(page, commentsSel, 15000, ct);
        await Task.Delay(1500 + rnd.Next(1000), ct);


        // === 4. ВОЗВРАТ В ГОЛОВУ ===
        Log(log, "→ Этап 4: Возврат в начало");
        await SmoothScrollTo(page, 0, 2000, ct);
        await Task.Delay(1000, ct);

        Log(log, "[OK] Ознакомление завершено (2–3 мин)");
    }

    // ────────────────────────────────────────────────────────
    // ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ
    // ────────────────────────────────────────────────────────

    private static async Task ReadPageCoreAsync(IPage page, Profile profile, Action<string>? log, CancellationToken ct)
    {
        string url = await page.EvaluateAsync<string>("() => location.href");
        bool isLitNet = url.Contains("litnet.com");
        bool isLitMarket = url.Contains("litmarket.ru");

        if (isLitNet)
        {
            Log(log, "[INFO] LitNet: чтение главы");
            await ReadLitNetAsync(page, profile, log, ct);
        }
        else if (isLitMarket)
        {
            Log(log, "[INFO] LitMarket: чтение главы");
            await ReadLitMarketAsync(page, profile, log, ct);
        }
        else
        {
            Log(log, "[WARN] Неизвестная платформа — fallback");
            int maxScroll = await page.EvaluateAsync<int>("() => document.body.scrollHeight - window.innerHeight");
            await ScrollTargetAsync(page, profile, maxScroll, "window", log, ct);
        }
    }

    private static async Task ReadLitNetAsync(IPage page, Profile profile, Action<string>? log, CancellationToken ct)
    {
        int lastScrollHeight = await page.EvaluateAsync<int>("() => document.body.scrollHeight");
        int currentPage = 1;

        while (!ct.IsCancellationRequested)
        {
            int maxScroll = await page.EvaluateAsync<int>("() => document.body.scrollHeight - window.innerHeight");
            await ScrollTargetAsync(page, profile, maxScroll, "window", log, ct);

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
            await Task.Delay(500, ct);
        }
    }

    private static async Task ReadLitMarketAsync(IPage page, Profile profile, Action<string>? log, CancellationToken ct)
    {
        await page.WaitForSelectorAsync(".frame-content", new PageWaitForSelectorOptions { Timeout = 8000 });
        await page.WaitForFunctionAsync(@"() => document.querySelector('.frame-content p')",
            new PageWaitForFunctionOptions { Timeout = 5000 });

        var paras = await page.EvaluateAsync<string[]>(@"
            () => Array.from(document.querySelectorAll('.frame-content p'))
                .map(p => p.innerText.trim()).filter(t => t.length > 5)");

        var rnd = new Random();
        double fatigue = 1.0;
        for (int i = 0; i < paras.Length && !ct.IsCancellationRequested; i++)
        {
            if (i > 0 && rnd.NextDouble() < 0.12)
            {
                int to = Math.Max(0, i - 1);
                await ScrollToParagraph(page, to, 100, ct);
                await Task.Delay(100 + rnd.Next(100), ct);
                i = Math.Max(0, i - 2);
                continue;
            }

            int dur = 200 + rnd.Next(50) * (int)(profile == Profile.TiredReader ? fatigue : 1.0);
            await ScrollToParagraph(page, i, dur, ct);

            int pause = 200 + rnd.Next(150) * (int)(profile == Profile.TiredReader ? fatigue : 1.0);
            await Task.Delay(pause, ct);

            if (profile == Profile.TiredReader)
                fatigue = 1.0 + Math.Log(1 + i * 0.12);
        }
    }

    private static async Task ScrollTargetAsync(
        IPage page, Profile profile, int maxScroll, string mode,
        Action<string>? log, CancellationToken ct)
    {
        if (maxScroll <= 0) maxScroll = 500;
        var rnd = new Random();
        int pos = 0;

        while (pos < maxScroll && !ct.IsCancellationRequested)
        {
            if (pos > 300 && rnd.NextDouble() < (profile switch
            {
                Profile.DeepReader => 0.20,
                Profile.TiredReader => 0.12,
                _ => 0.03
            }))
            {
                int to = Math.Max(100, pos - rnd.Next(80, 200));
                await SmoothScrollTo(page, to, 800, ct);
                await Task.Delay(500 + rnd.Next(400), ct);
                pos = to;
                continue;
            }

            int step = profile switch
            {
                Profile.DeepReader => 200 + rnd.Next(80),
                Profile.SpeedReader => 350 + rnd.Next(120),
                _ => 280 + rnd.Next(100)
            };
            int next = Math.Min(pos + step, maxScroll);

            int dur = profile switch
            {
                Profile.DeepReader => 1600 + rnd.Next(800),
                Profile.SpeedReader => 600 + rnd.Next(300),
                _ => 1000 + rnd.Next(500)
            };
            await SmoothScrollTo(page, next, dur, ct);

            int pause = profile switch
            {
                Profile.DeepReader => 1800 + rnd.Next(1200),
                Profile.SpeedReader => 400 + rnd.Next(250),
                _ => 900 + rnd.Next(750)
            };
            await Task.Delay(pause, ct);
            pos = next;
        }
    }

    private static async Task ScrollToParagraph(IPage page, int index, int ms, CancellationToken ct)
    {
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
        await Task.Delay(50, ct);
    }

    private static async Task SmoothScrollTo(IPage page, int targetY, int ms, CancellationToken ct)
    {
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
        await Task.Delay(50, ct);
    }

    private static async Task<bool> IsElementVisible(IPage page, string sel)
    {
        try { return await page.EvaluateAsync<bool>($"() => !!document.querySelector('{sel}')"); }
        catch { return false; }
    }

    private static async Task ScrollTo(IPage page, string sel, int dur, CancellationToken ct)
    {
        try
        {
            int top = await page.EvaluateAsync<int>($@"
                () => {{
                    const el = document.querySelector('{sel}');
                    return el ? el.getBoundingClientRect().top + window.scrollY - 80 : window.scrollY;
                }}");
            if (top > 0) await SmoothScrollTo(page, top, dur, ct);
        }
        catch { }
    }

    private static void Log(Action<string>? cb, string m) =>
        cb?.Invoke($"[{DateTime.Now:HH:mm:ss.fff}] {m}");
}