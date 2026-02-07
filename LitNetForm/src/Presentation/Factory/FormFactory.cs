using Core.Entities;
using LitPulse.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace LitPulse.Factory;

public sealed class FormFactory
{
    private readonly IServiceProvider _services;

    public FormFactory(IServiceProvider services)
    {
        _services = services;
    }

    public async Task<List<Account>> ShowAccountSetupForm()
    {
        await using var scope = _services.CreateAsyncScope();
        var form = scope.ServiceProvider.GetRequiredService<AccountSetupForm>();
        
        if (form.ShowDialog() == DialogResult.OK)
        {
            var result = form.GetActiveAccountsForStart();
            return result;
        }
        return [];
    }
}