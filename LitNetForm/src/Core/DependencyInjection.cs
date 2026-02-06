using Core.Factory;
using Core.Handlers;
using Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Core;

public static class DependencyInjection
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        services.AddScoped<StartSingleThreadHandler>();
        services.AddScoped<StartMultithreadHandler>();
        services.AddScoped<StartBatchMultithreadHandler>();
        services.AddScoped<StartLitNetHandler>();
        services.AddScoped<StartLitMarketHandler>();

        services.AddScoped<AccountsService>();
        services.AddScoped<AccountHistoryService>();
        services.AddScoped<LitMarketService>();
        services.AddScoped<LitNetService>();

        services.AddScoped<ScrollModel>();

        services.AddScoped<ServiceFactory>();

        services.AddSingleton<ReportService>();

        return services;
    }
}