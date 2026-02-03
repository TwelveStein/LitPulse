using Contracts.DTOs;
using LitPulse.Factory;
using LitPulse.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace LitPulse;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddScoped<IProgress<ReportDataDto>>(sp =>
        {
            var form = sp.GetRequiredService<MainForm>();
            return new Progress<ReportDataDto>(dto => form.WriteDataToTheReport(dto));
        });
        
        services.AddSingleton<MainForm>();
        services.AddSingleton<FormFactory>();

        services.AddTransient<AccountSetupForm>();
        
        return services;
    }
}