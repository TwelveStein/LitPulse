using Microsoft.Extensions.DependencyInjection;

namespace Core.Factory;

/// <summary>
/// Фабрика сервисов
/// </summary>
public sealed class ServiceFactory
{
    private readonly IServiceProvider _serviceProvider;
    
    public ServiceFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    /// <summary>
    /// Получает необходимый сервис из DI и выполняет его.
    /// Для каждого потока важно получать свой (отдельный) сервис и выполнять его в рамках созданного scope.
    /// </summary>
    public async Task ExecuteInService<TService>(
        Func<TService, Task> action) where TService : notnull
    {
        await using var scope = _serviceProvider.CreateAsyncScope();
        var service = scope.ServiceProvider.GetRequiredService<TService>();

        await action(service);
    }
}