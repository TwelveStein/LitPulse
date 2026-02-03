using System.Collections.Concurrent;
using Core.Abstracts;

namespace Core.Manager;

/// <summary>
/// Менеджер сервисов, используется для отслеживания сервисов, которые работаю в потоке, чтобы их завершить
/// </summary>
public sealed class ServiceManager
{
    // Используем thread-safe коллекцию, чтобы фиксировать сервисы из разных потоков
    private readonly ConcurrentBag<IBookService> _activeServices = [];

    /// <summary>
    /// Фиксирует сервис как активный
    /// </summary>
    public void RegisterService(IBookService bookService)
    {
        _activeServices.Add(bookService);
    }

    /// <summary>
    /// Завершает работу всех сервисов
    /// </summary>
    public async Task CompleteServices()
    {
        foreach (var service in _activeServices)
        {
            await service.DisposeAsync();
        }
        _activeServices.Clear();
    }
}