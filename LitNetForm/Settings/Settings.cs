using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using LitPulse.Bots;

namespace LitNetForm.Settings
{
    public class Settings
    {
        [JsonPropertyName("ReadBook")]
        public bool ReadBook { get; set; }

        [JsonPropertyName("AddToLibrary")]
        public bool AddToLibrary { get; set; }

        [JsonPropertyName("LikeTheBook")]
        public bool LikeTheBook { get; set; }

        [JsonPropertyName("SubscribeToTheAuthor")]
        public bool SubscribeToTheAuthor { get; set; }

        [JsonPropertyName("PostComment")]
        public bool PostComment { get; set; }

        [JsonPropertyName("MakeADonationToTheAuthor")]
        public bool MakeADonationToTheAuthor { get; set; }

        [JsonPropertyName("BuyABook")]
        public bool BuyABook {  get; set; }

        [JsonPropertyName("ConstantDelay")]
        public int ConstantDelay { get; set; }

        [JsonPropertyName("FloatingIncrementalDelay")]
        public int FloatingIncrementalDelay { get; set; }

        [JsonPropertyName("ReadProfile")]
        public Scroll_model.Profile ReadProfile { get; set; }

        [JsonPropertyName("ReadProfileSettings")]
        public Dictionary<Scroll_model.Profile, ProfileSettings>? ReadProfileSettings { get; set; } = new Dictionary<Scroll_model.Profile, ProfileSettings>();
    }

    [Serializable]
    public class ProfileSettings
    {
        /// <summary>
        /// Шанс регрессии (%)
        /// Диапозон: 0 - 100
        /// </summary>
        [JsonPropertyName("ChanceOfRegression")]
        [Range(0, 100)]
        public uint ChanceOfRegression { get; set; }

        /// <summary>
        /// Мин/макс шаг прокрутки (px)
        /// Диапозон: 50 - 1 500
        /// </summary>
        [JsonPropertyName("MinMaxScrollStep")]
        [Range(50, 1500)]
        public uint MinMaxScrollStep { get; set; }

        /// <summary>
        /// Мин/макс длительность прокрутки (мс)
        /// Диапозон: 300 - 5 000
        /// </summary>
        [JsonPropertyName("MinMaxScrollDuration")]
        [Range(300, 5000)]
        public uint MinMaxScrollDuration { get; set; }

        /// <summary>
        /// Мин/макс пауза после прокрутки (мс)
        /// Диапозон: 200 - 5 000  
        /// </summary>
        [JsonPropertyName("MinMaxPauseAfterScrolling")]
        [Range(200, 5000)]
        public uint MinMaxPauseAfterScrolling { get; set; }
    }

    public class SettingsManager
    {
        private static readonly string SettingsPath =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "LitNetForm", "settings.json");

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

        public static void Save(Settings settings)
        {
            try
            {
                // Создаем директорию, если её нет
                var directory = Path.GetDirectoryName(SettingsPath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                var options = GetJsonOptions();
                string json = JsonSerializer.Serialize(settings, options);
                File.WriteAllText(SettingsPath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения настроек: {ex.Message}");
            }
        }

        public static Settings Load()
        {
            try
            {
                if (!File.Exists(SettingsPath))
                {
                    return CreateDefaultSettings();
                }

                string json = File.ReadAllText(SettingsPath);

                var options = GetJsonOptions();

                var settings = JsonSerializer.Deserialize<Settings>(json, options);

                // Проверяем, что десериализация прошла успешно
                if (settings == null)
                {
                    return CreateDefaultSettings();
                }

                // Инициализируем словарь, если он null
                settings.ReadProfileSettings ??= new Dictionary<Scroll_model.Profile, ProfileSettings>();

                return settings;
            }
            catch (JsonException jsonEx)
            {
                // Специальная обработка ошибок JSON
                MessageBox.Show($"Ошибка формата JSON: {jsonEx.Message}\nСоздаются настройки по умолчанию.");
                return CreateDefaultSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки настроек: {ex.Message}");
                return CreateDefaultSettings();
            }
        }

        private static Settings CreateDefaultSettings()
        {
            Dictionary<Scroll_model.Profile, ProfileSettings> ReadProfileSettings = new Dictionary<Scroll_model.Profile, ProfileSettings>();
            ReadProfileSettings.Add(Scroll_model.Profile.SpeedReader, CreateDefaultReadProfileSettings(Scroll_model.Profile.SpeedReader));
            ReadProfileSettings.Add(Scroll_model.Profile.TiredReader, CreateDefaultReadProfileSettings(Scroll_model.Profile.TiredReader));
            ReadProfileSettings.Add(Scroll_model.Profile.DeepReader, CreateDefaultReadProfileSettings(Scroll_model.Profile.DeepReader));

            return new Settings
            {
                ReadBook = true,
                AddToLibrary = false,
                LikeTheBook = true,
                SubscribeToTheAuthor = false,
                PostComment = false,
                MakeADonationToTheAuthor = false,
                BuyABook = false,
                ConstantDelay = 1,
                FloatingIncrementalDelay = 1,
                ReadProfile = Scroll_model.Profile.SpeedReader,
                ReadProfileSettings = ReadProfileSettings
            };
        }

        public static ProfileSettings CreateDefaultReadProfileSettings(Scroll_model.Profile ReadProfile)
        {
            ProfileSettings ReadProfileSettings = new ProfileSettings();

            switch (ReadProfile)
            {
                case Scroll_model.Profile.SpeedReader:

                    ReadProfileSettings = new ProfileSettings
                    {
                        ChanceOfRegression = 3,
                        MinMaxScrollStep = 350,
                        MinMaxScrollDuration = 600,
                        MinMaxPauseAfterScrolling = 400
                    };

                    break;
                case Scroll_model.Profile.DeepReader:

                    ReadProfileSettings = new ProfileSettings
                    {
                        ChanceOfRegression = 20,
                        MinMaxScrollStep = 200,
                        MinMaxScrollDuration = 1600,
                        MinMaxPauseAfterScrolling = 1800
                    };

                    break;

                case Scroll_model.Profile.TiredReader:

                    ReadProfileSettings = new ProfileSettings
                    {
                        ChanceOfRegression = 12,
                        MinMaxScrollStep = 280,
                        MinMaxScrollDuration = 1000,
                        MinMaxPauseAfterScrolling = 900
                    };

                    break;
                default:

                    ReadProfileSettings = new ProfileSettings
                    {
                        ChanceOfRegression = 0,
                        MinMaxScrollStep = 0,
                        MinMaxScrollDuration = 0,
                        MinMaxPauseAfterScrolling = 0
                    };

                    break;
            }

            return ReadProfileSettings;
        }
    }
}
