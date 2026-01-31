using Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Core;

public static class DependencyInjection
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        services.AddScoped<AccountsService>();
        services.AddScoped<AccountHistoryService>();
        services.AddScoped<LitMarketService>();
        services.AddScoped<LitNetService>();
        services.AddScoped<ScrollModel>();
        
        return services;
    }
}