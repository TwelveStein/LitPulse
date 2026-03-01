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

        // Класс-обертка для хранения данных
        private class StorageData
        {
            public List<Proxys> Proxies { get; set; }
            public bool UseProxy { get; set; }
        }

        static ProxysService()
        {
            // Стандартная директория для хранения данных приложения
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appFolder = Path.Combine(appDataPath, "LitPulse");

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

        public static bool UseProxy = false;

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

        public static void SaveToStorage()
        {
            try
            {
                var storageData = new StorageData
                {
                    Proxies = _proxies,
                    UseProxy = UseProxy
                };

                var json = JsonSerializer.Serialize(storageData, new JsonSerializerOptions { WriteIndented = true });
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
                    var storageData = JsonSerializer.Deserialize<StorageData>(json);

                    if (storageData != null)
                    {
                        _proxies = storageData.Proxies ?? new List<Proxys>();
                        UseProxy = storageData.UseProxy;
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

        /// <summary>
        /// Удаляет указанный объект прокси из списка и сохраняет изменения
        /// </summary>
        /// <param name="proxy">Прокси для удаления</param>
        /// <returns>true - если прокси был удален, false - если прокси не найден</returns>
        public static bool RemoveProxy(Proxys proxy)
        {
            if (proxy == null)
                throw new ArgumentNullException(nameof(proxy));

            lock (_lock)
            {
                bool removed = _proxies.Remove(proxy);

                if (removed)
                {
                    SaveToStorage();
                }

                return removed;
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
