using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.Services
{
    public sealed class ProxysService
    {
        private static List<Proxys> _proxies = new List<Proxys>();
        private static readonly string _storagePath;
        private static readonly Random _random = new Random();
        private static readonly object _lock = new object();

        static ProxysService()
        {
            // Стандартная директория для хранения данных приложения
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appFolder = Path.Combine(appDataPath, "ProxysService");

            if (!Directory.Exists(appFolder))
            {
                Directory.CreateDirectory(appFolder);
            }

            _storagePath = Path.Combine(appFolder, "proxies.json");

            // Автоматическая загрузка при старте, если файл существует
            LoadFromStorage();
        }

        public static IReadOnlyList<Proxys> Proxies => _proxies.AsReadOnly();

        public static int Count => _proxies.Count;

        public static void LoadFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException("Файл не найден", filePath);

                var lines = File.ReadAllLines(filePath);
                var newProxies = new List<Proxys>();

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var proxy = Proxys.Parse(line.Trim());
                    if (proxy != null)
                    {
                        newProxies.Add(proxy);
                    }
                }

                lock (_lock)
                {
                    _proxies = newProxies;
                    SaveToStorage();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка загрузки прокси из файла: {ex.Message}", ex);
            }
        }

        private static void SaveToStorage()
        {
            try
            {
                var json = JsonSerializer.Serialize(_proxies);
                File.WriteAllText(_storagePath, json);
            }
            catch (Exception ex)
            {
                // Логирование ошибки сохранения
                System.Diagnostics.Debug.WriteLine($"Ошибка сохранения: {ex.Message}");
            }
        }

        private static void LoadFromStorage()
        {
            try
            {
                if (File.Exists(_storagePath))
                {
                    var json = File.ReadAllText(_storagePath);
                    var loaded = JsonSerializer.Deserialize<List<Proxys>>(json);
                    if (loaded != null)
                    {
                        _proxies = loaded;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Ошибка загрузки из хранилища: {ex.Message}");
                _proxies = new List<Proxys>();
            }
        }

        public static void Clear()
        {
            lock (_lock)
            {
                _proxies.Clear();
                SaveToStorage();
            }
        }

        public static Proxys GetRandomProxy()
        {
            lock (_lock)
            {
                if (_proxies.Count == 0)
                    return null;

                int index = _random.Next(_proxies.Count);
                return _proxies[index];
            }
        }

        public static string GetStoragePath()
        {
            return _storagePath;
        }
    }
}
