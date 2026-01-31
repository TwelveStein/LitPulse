using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LitPulse.Data
{
    public class Accounts
    {
        public string? Login {  get; set; }
        public string? Password { get; set; }

        public Accounts(string login, string password)
        {
            Login = login.Trim();
            Password = password.Trim();
        }

        public override string ToString()
        {
            return $"{Login} : {Password}";
        }
    }

    public class AccountsManager
    {
        private static readonly string AccountsPath =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "LitNetForm", "Accounts.json");

        public static void Save(BindingList<Accounts> accounts)
        {
            try
            {
                // Создаем директорию, если её нет
                var directory = Path.GetDirectoryName(AccountsPath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                var options = GetJsonOptions();
                string json = JsonSerializer.Serialize(accounts, options);
                File.WriteAllText(AccountsPath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения аккаунтов: {ex.Message}");
            }
        }

        public static BindingList<Accounts> Load()
        {
            try
            {
                if (!File.Exists(AccountsPath))
                {
                    return CreateDefaultEmptyAccounts();
                }

                string json = File.ReadAllText(AccountsPath);

                var options = GetJsonOptions();

                var accounts = JsonSerializer.Deserialize< BindingList<Accounts>> (json, options);

                // Проверяем, что десериализация прошла успешно
                if (accounts == null)
                {
                    return CreateDefaultEmptyAccounts();
                }

                return accounts;
            }
            catch (JsonException jsonEx)
            {
                return CreateDefaultEmptyAccounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки аккаунтов: {ex.Message}");
                return CreateDefaultEmptyAccounts();
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

        private static BindingList<Accounts> CreateDefaultEmptyAccounts()
        {
            return new BindingList<Accounts>();
        }
    }
}
