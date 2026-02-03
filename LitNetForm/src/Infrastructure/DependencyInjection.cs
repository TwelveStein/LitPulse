using Core.Abstracts;
using Infrastructure.Database;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<DatabaseInitializer>();
        
        services.AddScoped<AppDbContext>();
        
        services.AddScoped<IAccountsRepository, AccountsRepository>();
        services.AddScoped<IAccountHistoryRepository, AccountHistoryRepository>();
        
        return services;
    }
}