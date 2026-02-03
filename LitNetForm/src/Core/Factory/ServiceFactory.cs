using Microsoft.Extensions.DependencyInjection;

namespace Core.Factory;

/// <summary>
/// Фабрика сервисов, предоставляет необходимый сервис из IServiceProvider
/// </summary>
public sealed class ServiceFactory
{
    private readonly IServiceProvider _serviceProvider;
    
    public ServiceFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    /// <summary>
    /// Возвращает необходимый сервис из DI
    /// </summary>
    public async Task<TService> GetServiceAsync<TService>() where TService : notnull 
    {
        await using var scope = _serviceProvider.CreateAsyncScope();
        var service = scope.ServiceProvider.GetRequiredService<TService>();
        return service;
    }
}