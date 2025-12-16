using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LitNetForm.Data
{
    public class Links
    {
        public string? Link { get; set; }
    
        public Links(string link)
        {
            Link = link.Trim();
        }   
    }

    public class LinksManager
    {
        private static readonly string LinksPath =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "LitNetForm", "Links.json");

        public static void Save(BindingList<Links> accounts)
        {
            try
            {
                // Создаем директорию, если её нет
                var directory = Path.GetDirectoryName(LinksPath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                var options = GetJsonOptions();
                string json = JsonSerializer.Serialize(accounts, options);
                File.WriteAllText(LinksPath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения аккаунтов: {ex.Message}");
            }
        }

        public static BindingList<Links> Load()
        {
            try
            {
                if (!File.Exists(LinksPath))
                {
                    return CreateDefaultEmptyLinks();
                }

                string json = File.ReadAllText(LinksPath);

                var options = GetJsonOptions();

                var accounts = JsonSerializer.Deserialize<BindingList<Links>>(json, options);

                // Проверяем, что десериализация прошла успешно
                if (accounts == null)
                {
                    return CreateDefaultEmptyLinks();
                }

                return accounts;
            }
            catch (JsonException jsonEx)
            {
                return CreateDefaultEmptyLinks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки аккаунтов: {ex.Message}");
                return CreateDefaultEmptyLinks();
            }
        }

        // Общие настройки JSON-сериализации
        private static JsonSerializerOptions GetJsonOptions()
        {
            return new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter() },
                // Используем Preserve для корректной работы со сложными объектами и словарями
                ReferenceHandler = ReferenceHandler.Preserve,
                // Для лучшей совместимости
                PropertyNameCaseInsensitive = true
            };
        }

        private static BindingList<Links> CreateDefaultEmptyLinks()
        {
            return new BindingList<Links>();
        }
    }
}