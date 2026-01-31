using LitPulse.Factory;
using LitPulse.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace LitPulse;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddSingleton<MainForm>();
        services.AddSingleton<FormFactory>();

        services.AddTransient<AccountSetupForm>();
        
        return services;
    }
}