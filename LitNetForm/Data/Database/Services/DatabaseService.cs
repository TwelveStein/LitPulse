using LitNetForm.Data;
using LitPulse.Bots;
using LitPulse.Data.Database;
using LitPulse.Data.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection;
using LitNetForm.Settings;
using static LitPulse.Bots.Scroll_model;

namespace LitPulse.Data.Database.Services
{
    public class DatabaseService
    {
        private readonly AppDbContext _context;

        public DatabaseService()
        {
            _context = new AppDbContext();
        }

        #region Инициализация и проверка БД

        /// <summary>
        /// Проверяет и создает БД и таблицы при необходимости
        /// </summary>
        public void InitializeDatabase()
        {
            try
            {
                Console.WriteLine("Проверка базы данных...");

                // 1. Проверяем существование файла БД
                bool databaseFileExists = File.Exists(AppDbContext.GetDatabasePath());

                // 2. Создаем БД и применяем миграции
                _context.Database.EnsureCreated();

                if (!databaseFileExists)
                {
                    Debug.WriteLine("Создана новая база данных.");

                    // Добавляем начальные данные, если нужно
                    SeedInitialData();
                }
                else
                {
                    Debug.WriteLine("База данных существует.");

                    // Проверяем и обновляем схему
                    UpdateDatabaseSchema();
                }

                // 3. Проверяем существование таблицы Accounts, AccountsSettings, ProfileSettings
                bool tableAccountsExists = _context.Database.CanConnect() &&
                                  _context.Accounts.Any(); // Проверка через запрос

                bool tableAccountsSettingsExists = _context.Database.CanConnect() &&
                                  _context.Accounts.Any(); // Проверка через запрос

                bool tableProfileSettingsExists = _context.Database.CanConnect() &&
                                  _context.Accounts.Any(); // Проверка через запрос

                Debug.WriteLine($"Таблица Accounts: {(tableAccountsExists ? "существует" : "не найдена")}");

                // 4. Проверяем и добавляем отсутствующие колонки
                CheckAndAddMissingColumns();

                Debug.WriteLine("База данных готова к работе.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка инициализации БД: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Добавляет начальные тестовые данные
        /// </summary>
        private void SeedInitialData()
        {
            try
            {
                // Добавляем тестового пользователя
                var testAccount1 = new Account
                {
                    Login = "user1",
                    Password = "password321",
                    IsActive = true
                };

                var testAccount2 = new Account
                {
                    Login = "user2",
                    Password = "password123",
                    IsActive = true
                };

                _context.Accounts.AddRange(testAccount1, testAccount2);
                _context.SaveChanges();

                Debug.WriteLine("Добавлены начальные тестовые данные.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка добавления начальных данных: {ex.Message}");
            }
        }

        private void CreateDefaultSettingsForAccount(int accountId)
        {
            try
            {
                // Создаем основные настройки аккаунта
                var accountSettings = new AccountSettings
                {
                    AccountId = accountId,
                    ReadBook = true,
                    AddToLibrary = false,
                    LikeTheBook = true,
                    SubscribeToTheAuthor = false,
                    PostComment = false,
                    MakeADonationToTheAuthor = false,
                    BuyABook = false,
                    ConstantDelay = 1000,
                    FloatingIncrementalDelay = 500,
                    ReadProfile = Scroll_model.Profile.DeepReader
                };

                _context.AccountSettings.Add(accountSettings);
                _context.SaveChanges();

                // Создаем настройки профилей по умолчанию
                InitializeProfileSettings(accountSettings.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка создания настроек по умолчанию: {ex.Message}");
            }
        }

        private void InitializeProfileSettings(int accountSettingsId)
        {
            var defaultProfiles = new Dictionary<Scroll_model.Profile, Models.ProfileSettings>
            {
                [Scroll_model.Profile.TiredReader] = new Models.ProfileSettings
                {
                    AccountSettingsId = accountSettingsId,
                    ProfileType = Scroll_model.Profile.TiredReader,
                    ChanceOfRegression = 12,
                    MinMaxScrollStep = 280,
                    MinMaxScrollDuration = 1000,
                    MinMaxPauseAfterScrolling = 900
                },
                [Scroll_model.Profile.SpeedReader] = new Models.ProfileSettings
                {
                    AccountSettingsId = accountSettingsId,
                    ProfileType = Scroll_model.Profile.SpeedReader,
                    ChanceOfRegression = 3,
                    MinMaxScrollStep = 350,
                    MinMaxScrollDuration = 600,
                    MinMaxPauseAfterScrolling = 400
                },
                [Scroll_model.Profile.DeepReader] = new Models.ProfileSettings
                {
                    AccountSettingsId = accountSettingsId,
                    ProfileType = Scroll_model.Profile.DeepReader,
                    ChanceOfRegression = 20,
                    MinMaxScrollStep = 200,
                    MinMaxScrollDuration = 1600,
                    MinMaxPauseAfterScrolling = 1800
                }
            };

            _context.ProfileSettings.AddRange(defaultProfiles.Values);
            _context.SaveChanges();
        }

        /// <summary>
        /// Проверяет и добавляет отсутствующие колонки в таблицу
        /// </summary>
        private void CheckAndAddMissingColumns()
        {
            try
            {
                // Получаем все свойства модели Account
                var accountProperties = typeof(Account).GetProperties()
                    .Where(p => p.Name != "AdditionalData") // Исключаем NotMapped свойство
                    .Select(p => p.Name)
                    .ToList();

                // Получаем существующие колонки через raw SQL
                var existingColumns = GetExistingTableColumns("Accounts");

                // Находим отсутствующие колонки
                var missingColumns = accountProperties.Except(existingColumns).ToList();

                if (missingColumns.Any())
                {
                    Debug.WriteLine($"Найдены отсутствующие колонки: {string.Join(", ", missingColumns)}");

                    // Для каждой отсутствующей колонки пытаемся определить тип
                    foreach (var columnName in missingColumns)
                    {
                        AddColumnToTable(columnName);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка проверки колонок: {ex.Message}");
            }
        }

        /// <summary>
        /// Получает список существующих колонок в таблице
        /// </summary>
        private List<string> GetExistingTableColumns(string tableName)
        {
            var columns = new List<string>();

            try
            {
                // SQLite запрос для получения информации о колонках
                var sql = $"PRAGMA table_info({tableName})";

                using var command = _context.Database.GetDbConnection().CreateCommand();
                command.CommandText = sql;

                _context.Database.OpenConnection();

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var columnName = reader.GetString(1); // name столбец
                    columns.Add(columnName);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка получения колонок таблицы: {ex.Message}");
            }
            finally
            {
                _context.Database.CloseConnection();
            }

            return columns;
        }

        /// <summary>
        /// Добавляет колонку в таблицу Accounts
        /// </summary>
        private void AddColumnToTable(string columnName)
        {
            try
            {
                // Получаем информацию о свойстве
                var property = typeof(Account).GetProperty(columnName);
                if (property == null) return;

                // Определяем тип SQL на основе типа свойства
                string sqlType = GetSqlType(property.PropertyType);

                // Создаем SQL запрос для добавления колонки
                var sql = $"ALTER TABLE Accounts ADD COLUMN {columnName} {sqlType}";

                _context.Database.ExecuteSqlRaw(sql);

                Debug.WriteLine($"Добавлена колонка: {columnName} ({sqlType})");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка добавления колонки {columnName}: {ex.Message}");
            }
        }

        /// <summary>
        /// Определяет SQL тип на основе типа C#
        /// </summary>
        private string GetSqlType(Type type)
        {
            if (type == typeof(string))
                return "TEXT";
            if (type == typeof(int) || type == typeof(int?))
                return "INTEGER";
            if (type == typeof(bool) || type == typeof(bool?))
                return "INTEGER"; // SQLite хранит bool как integer (0/1)
            if (type == typeof(DateTime) || type == typeof(DateTime?))
                return "DATETIME";
            if (type == typeof(decimal) || type == typeof(decimal?))
                return "REAL";

            return "TEXT"; // По умолчанию TEXT
        }

        /// <summary>
        /// Обновляет схему базы данных (упрощенная миграция)
        /// </summary>
        private void UpdateDatabaseSchema()
        {
            try
            {
                // Получаем текущую версию схемы (храним в отдельной таблице)
                EnsureSchemaVersionTable();

                int currentVersion = GetCurrentSchemaVersion();
                int targetVersion = 1; // Текущая версия схемы

                if (currentVersion < targetVersion)
                {
                    Debug.WriteLine($"Обновление схемы с версии {currentVersion} до {targetVersion}");

                    // Здесь можно добавить логику обновления между версиями
                    // Например, если currentVersion == 0, а targetVersion == 1

                    UpdateSchemaVersion(targetVersion);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка обновления схемы: {ex.Message}");
            }
        }

        private void EnsureSchemaVersionTable()
        {
            var sql = @"
                CREATE TABLE IF NOT EXISTS SchemaVersion (
                    Id INTEGER PRIMARY KEY,
                    Version INTEGER NOT NULL,
                    UpdatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
                );
                
                INSERT OR IGNORE INTO SchemaVersion (Id, Version) VALUES (1, 0);
            ";

            _context.Database.ExecuteSqlRaw(sql);
        }

        private int GetCurrentSchemaVersion()
        {
            var sql = "SELECT Version FROM SchemaVersion WHERE Id = 1";
            var result = _context.Database.SqlQueryRaw<int>(sql).FirstOrDefault();
            return result;
        }

        private void UpdateSchemaVersion(int version)
        {
            var sql = $"UPDATE SchemaVersion SET Version = {version}, UpdatedAt = CURRENT_TIMESTAMP WHERE Id = 1";
            _context.Database.ExecuteSqlRaw(sql);
        }

        #endregion

        #region CRUD операции

        /// <summary>
        /// Сохраняет настройки для аккаунта по логину
        /// </summary>
        public bool SaveSettings(string login, Settings settings)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                // Находим аккаунт
                var account = _context.Accounts
                    .FirstOrDefault(a => a.Login == login);

                if (account == null)
                {
                    Console.WriteLine($"Аккаунт с логином '{login}' не найден.");
                    return false;
                }

                // Получаем или создаем настройки аккаунта
                var accountSettings = _context.AccountSettings
                    .Include(a => a.ProfileSettings)
                    .FirstOrDefault(a => a.AccountId == account.Id);

                if (accountSettings == null)
                {
                    // Создаем новые настройки
                    accountSettings = new AccountSettings
                    {
                        AccountId = account.Id,
                        ReadBook = settings.ReadBook,
                        AddToLibrary = settings.AddToLibrary,
                        LikeTheBook = settings.LikeTheBook,
                        SubscribeToTheAuthor = settings.SubscribeToTheAuthor,
                        PostComment = settings.PostComment,
                        MakeADonationToTheAuthor = settings.MakeADonationToTheAuthor,
                        BuyABook = settings.BuyABook,
                        ConstantDelay = settings.ConstantDelay,
                        FloatingIncrementalDelay = settings.FloatingIncrementalDelay,
                        ReadProfile = settings.ReadProfile,
                        UpdatedAt = DateTime.UtcNow
                    };

                    _context.AccountSettings.Add(accountSettings);
                    _context.SaveChanges();

                    // Создаем настройки профилей
                    if (settings.ReadProfileSettings != null)
                    {
                        foreach (var (profileType, profileSettings) in settings.ReadProfileSettings)
                        {
                            var newProfileSettings = new Models.ProfileSettings
                            {
                                AccountSettingsId = accountSettings.Id,
                                ProfileType = profileType,
                                ChanceOfRegression = profileSettings.ChanceOfRegression,
                                MinMaxScrollStep = profileSettings.MinMaxScrollStep,
                                MinMaxScrollDuration = profileSettings.MinMaxScrollDuration,
                                MinMaxPauseAfterScrolling = profileSettings.MinMaxPauseAfterScrolling
                            };

                            _context.ProfileSettings.Add(newProfileSettings);
                        }
                    }
                    else
                    {
                        // Создаем настройки профилей по умолчанию
                        InitializeProfileSettings(accountSettings.Id);
                    }
                }
                else
                {
                    // Обновляем существующие настройки
                    accountSettings.ReadBook = settings.ReadBook;
                    accountSettings.AddToLibrary = settings.AddToLibrary;
                    accountSettings.LikeTheBook = settings.LikeTheBook;
                    accountSettings.SubscribeToTheAuthor = settings.SubscribeToTheAuthor;
                    accountSettings.PostComment = settings.PostComment;
                    accountSettings.MakeADonationToTheAuthor = settings.MakeADonationToTheAuthor;
                    accountSettings.BuyABook = settings.BuyABook;
                    accountSettings.ConstantDelay = settings.ConstantDelay;
                    accountSettings.FloatingIncrementalDelay = settings.FloatingIncrementalDelay;
                    accountSettings.ReadProfile = settings.ReadProfile;
                    accountSettings.UpdatedAt = DateTime.UtcNow;

                    // Обновляем или добавляем настройки профилей
                    if (settings.ReadProfileSettings != null)
                    {
                        foreach (var (profileType, newProfileSettings) in settings.ReadProfileSettings)
                        {
                            var existingProfileSettings = accountSettings.ProfileSettings
                                .FirstOrDefault(ps => ps.ProfileType == profileType);

                            if (existingProfileSettings != null)
                            {
                                // Обновляем существующие
                                existingProfileSettings.ChanceOfRegression = newProfileSettings.ChanceOfRegression;
                                existingProfileSettings.MinMaxScrollStep = newProfileSettings.MinMaxScrollStep;
                                existingProfileSettings.MinMaxScrollDuration = newProfileSettings.MinMaxScrollDuration;
                                existingProfileSettings.MinMaxPauseAfterScrolling = newProfileSettings.MinMaxPauseAfterScrolling;
                            }
                            else
                            {
                                // Добавляем новые
                                var profileSettings = new Models.ProfileSettings
                                {
                                    AccountSettingsId = accountSettings.Id,
                                    ProfileType = profileType,
                                    ChanceOfRegression = newProfileSettings.ChanceOfRegression,
                                    MinMaxScrollStep = newProfileSettings.MinMaxScrollStep,
                                    MinMaxScrollDuration = newProfileSettings.MinMaxScrollDuration,
                                    MinMaxPauseAfterScrolling = newProfileSettings.MinMaxPauseAfterScrolling
                                };

                                _context.ProfileSettings.Add(profileSettings);
                            }
                        }
                    }
                }

                _context.SaveChanges();
                transaction.Commit();

                Console.WriteLine($"Настройки для аккаунта '{login}' сохранены.");
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine($"Ошибка сохранения настроек: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Получает настройки для аккаунта по логину
        /// </summary>
        public Settings? GetSettings(string login)
        {
            try
            {
                // Находим аккаунт с настройками и профилями
                var account = _context.Accounts
                    .Include(a => _context.AccountSettings
                        .Where(a => a.AccountId == a.Id)
                        .Include(a => a.ProfileSettings))
                    .FirstOrDefault(a => a.Login == login);

                if (account == null)
                {
                    Console.WriteLine($"Аккаунт с логином '{login}' не найден.");
                    return null;
                }

                var accountSettings = _context.AccountSettings
                    .Include(a => a.ProfileSettings)
                    .FirstOrDefault(a => a.AccountId == account.Id);

                if (accountSettings == null)
                {
                    Console.WriteLine($"Для аккаунта '{login}' настроек не найдено.");
                    return new Settings(); // Возвращаем настройки по умолчанию
                }

                // Конвертируем в DTO
                return new Settings(accountSettings);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка получения настроек: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Получает настройки аккаунта по ID
        /// </summary>
        public AccountSettings? GetAccountSettings(int accountId)
        {
            return _context.AccountSettings
                .Include(a => a.ProfileSettings)
                .FirstOrDefault(a => a.AccountId == accountId);
        }

        /// <summary>
        /// Обновляет отдельную настройку аккаунта
        /// </summary>
        public bool UpdateAccountSetting(string login, string settingName, object value)
        {
            try
            {
                var account = _context.Accounts
                    .FirstOrDefault(a => a.Login == login);

                if (account == null)
                {
                    Console.WriteLine($"Аккаунт с логином '{login}' не найден.");
                    return false;
                }

                var accountSettings = _context.AccountSettings
                    .FirstOrDefault(a => a.AccountId == account.Id);

                if (accountSettings == null)
                {
                    Console.WriteLine($"Для аккаунта '{login}' настроек не найдено.");
                    return false;
                }

                // Обновляем свойство через рефлексию
                var property = typeof(AccountSettings).GetProperty(settingName);
                if (property == null)
                {
                    Console.WriteLine($"Свойство '{settingName}' не найдено.");
                    return false;
                }

                property.SetValue(accountSettings, Convert.ChangeType(value, property.PropertyType));
                accountSettings.UpdatedAt = DateTime.UtcNow;

                _context.SaveChanges();
                Console.WriteLine($"Настройка '{settingName}' для аккаунта '{login}' обновлена.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка обновления настройки: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Обновляет настройки профиля
        /// </summary>
        public bool UpdateProfileSetting(string login, Profile profileType, Models.ProfileSettings newSettings)
        {
            try
            {
                var account = _context.Accounts
                    .FirstOrDefault(a => a.Login == login);

                if (account == null)
                {
                    Console.WriteLine($"Аккаунт с логином '{login}' не найден.");
                    return false;
                }

                var accountSettings = _context.AccountSettings
                    .FirstOrDefault(a => a.AccountId == account.Id);

                if (accountSettings == null)
                {
                    Console.WriteLine($"Для аккаунта '{login}' настроек не найдено.");
                    return false;
                }

                var profileSettings = _context.ProfileSettings
                    .FirstOrDefault(ps => ps.AccountSettingsId == accountSettings.Id &&
                                         ps.ProfileType == profileType);

                if (profileSettings == null)
                {
                    // Создаем новые настройки профиля
                    profileSettings = new Models.ProfileSettings
                    {
                        AccountSettingsId = accountSettings.Id,
                        ProfileType = profileType,
                        ChanceOfRegression = newSettings.ChanceOfRegression,
                        MinMaxScrollStep = newSettings.MinMaxScrollStep,
                        MinMaxScrollDuration = newSettings.MinMaxScrollDuration,
                        MinMaxPauseAfterScrolling = newSettings.MinMaxPauseAfterScrolling
                    };

                    _context.ProfileSettings.Add(profileSettings);
                }
                else
                {
                    // Обновляем существующие
                    profileSettings.ChanceOfRegression = newSettings.ChanceOfRegression;
                    profileSettings.MinMaxScrollStep = newSettings.MinMaxScrollStep;
                    profileSettings.MinMaxScrollDuration = newSettings.MinMaxScrollDuration;
                    profileSettings.MinMaxPauseAfterScrolling = newSettings.MinMaxPauseAfterScrolling;
                }

                _context.SaveChanges();
                Console.WriteLine($"Настройки профиля '{profileType}' для аккаунта '{login}' обновлены.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка обновления настроек профиля: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Создает настройки по умолчанию для всех аккаунтов без настроек
        /// </summary>
        public void CreateDefaultSettingsForAllAccounts()
        {
            try
            {
                var accountsWithoutSettings = _context.Accounts
                    .Where(a => !_context.AccountSettings.Any(a => a.AccountId == a.Id))
                    .ToList();

                foreach (var account in accountsWithoutSettings)
                {
                    CreateDefaultSettingsForAccount(account.Id);
                }

                Console.WriteLine($"Созданы настройки по умолчанию для {accountsWithoutSettings.Count} аккаунтов.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка создания настроек по умолчанию: {ex.Message}");
            }
        }

        /// <summary>
        /// Удаляет все настройки для аккаунта
        /// </summary>
        public bool DeleteSettings(string login)
        {
            try
            {
                var account = _context.Accounts
                    .FirstOrDefault(a => a.Login == login);

                if (account == null)
                {
                    Console.WriteLine($"Аккаунт с логином '{login}' не найден.");
                    return false;
                }

                var accountSettings = _context.AccountSettings
                    .FirstOrDefault(a => a.AccountId == account.Id);

                if (accountSettings != null)
                {
                    // ProfileSettings удалятся каскадно из-за настроек в DbContext
                    _context.AccountSettings.Remove(accountSettings);
                    _context.SaveChanges();
                    Console.WriteLine($"Настройки для аккаунта '{login}' удалены.");
                    return true;
                }

                Console.WriteLine($"Для аккаунта '{login}' настроек не найдено.");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка удаления настроек: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Добавляет новый аккаунт
        /// </summary>
        public bool AddAccount(Account account)
        {
            try
            {
                // Проверяем, не существует ли уже аккаунт с таким логином
                if (_context.Accounts.Any(a => a.Login == account.Login))
                {
                    Debug.WriteLine($"Аккаунт с логином '{account.Login}' уже существует.");
                    return false;
                }

                // Хэшируем пароль перед сохранением
                account.Password = account.Password;

                _context.Accounts.Add(account);
                _context.SaveChanges();

                Debug.WriteLine($"Аккаунт '{account.Login}' успешно добавлен (ID: {account.Id}).");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка добавления аккаунта: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Добавляет новый аккаунт с минимальными данными
        /// </summary>
        public bool AddAccount(string login, string password, string email = null)
        {
            var account = new Account
            {
                Login = login,
                Password = password
            };

            return AddAccount(account);
        }

        /// <summary>
        /// Получает аккаунт по ID
        /// </summary>
        public Account GetAccountById(int id)
        {
            return _context.Accounts.Find(id);
        }

        /// <summary>
        /// Получает аккаунт по логину
        /// </summary>
        public Account GetAccountByLogin(string login)
        {
            return _context.Accounts.FirstOrDefault(a => a.Login == login);
        }

        /// <summary>
        /// Получает все аккаунты
        /// </summary>
        public List<Account> GetAllAccounts()
        {
            return _context.Accounts.ToList();
        }

        /// <summary>
        /// Обновляет аккаунт
        /// </summary>
        public bool UpdateAccount(Account account)
        {
            try
            {
                var existingAccount = _context.Accounts.Find(account.Id);
                if (existingAccount == null)
                {
                    Debug.WriteLine($"Аккаунт с ID {account.Id} не найден.");
                    return false;
                }

                // Проверяем, не занят ли новый логин другим аккаунтом
                if (account.Login != existingAccount.Login &&
                    _context.Accounts.Any(a => a.Login == account.Login))
                {
                    Debug.WriteLine($"Логин '{account.Login}' уже используется.");
                    return false;
                }

                // Обновляем поля (кроме пароля, если он не изменился)
                if (!string.IsNullOrEmpty(account.Password) && account.Password != existingAccount.Password)
                {
                    existingAccount.Password = account.Password;
                }

                existingAccount.Login = account.Login;

                _context.SaveChanges();

                Debug.WriteLine($"Аккаунт '{account.Login}' успешно обновлен.");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка обновления аккаунта: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Обновляет пароль аккаунта
        /// </summary>
        public bool UpdateAccountPassword(int accountId, string newPassword)
        {
            try
            {
                var account = _context.Accounts.Find(accountId);
                if (account == null)
                {
                    Debug.WriteLine($"Аккаунт с ID {accountId} не найден.");
                    return false;
                }

                account.Password = newPassword;
                _context.SaveChanges();

                Debug.WriteLine($"Пароль аккаунта '{account.Login}' обновлен.");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка обновления пароля: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Удаляет аккаунт по ID
        /// </summary>
        public bool DeleteAccount(int id)
        {
            try
            {
                var account = _context.Accounts.Find(id);
                if (account == null)
                {
                    Debug.WriteLine($"Аккаунт с ID {id} не найден.");
                    return false;
                }

                _context.Accounts.Remove(account);
                _context.SaveChanges();

                Debug.WriteLine($"Аккаунт '{account.Login}' удален.");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка удаления аккаунта: {ex.Message}");
                return false;
            }
        }

        #endregion

        #region Вспомогательные методы

        /// <summary>
        /// Получает все аккаунты с их настройками
        /// </summary>
        public List<(Account Account, Settings Settings)> GetAllAccountsWithSettings()
        {
            var result = new List<(Account, Settings)>();

            try
            {
                var accounts = _context.Accounts.ToList();

                foreach (var account in accounts)
                {
                    var settings = GetSettings(account.Login);
                    if (settings != null)
                    {
                        result.Add((account, settings));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка получения аккаунтов с настройками: {ex.Message}");
            }

            return result;
        }

        /// <summary>
        /// Получает настройки профиля для аккаунта
        /// </summary>
        public Models.ProfileSettings? GetProfileSettings(string login, Profile profileType)
        {
            try
            {
                var account = _context.Accounts
                    .FirstOrDefault(a => a.Login == login);

                if (account == null) return null;

                return _context.ProfileSettings
                    .FirstOrDefault(ps => ps.AccountSettings.AccountId == account.Id &&
                                         ps.ProfileType == profileType);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка получения настроек профиля: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Получает все профильные настройки для аккаунта
        /// </summary>
        public Dictionary<Profile, Models.ProfileSettings> GetAllProfileSettings(string login)
        {
            var result = new Dictionary<Profile, Models.ProfileSettings>();

            try
            {
                var account = _context.Accounts
                    .FirstOrDefault(a => a.Login == login);

                if (account == null) return result;

                var profileSettings = _context.ProfileSettings
                    .Where(ps => ps.AccountSettings.AccountId == account.Id)
                    .ToList();

                foreach (var setting in profileSettings)
                {
                    result[setting.ProfileType] = setting;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка получения всех профильных настроек: {ex.Message}");
            }

            return result;
        }

        /// <summary>
        /// Проверяет пароль
        /// </summary>
        private bool VerifyPassword(string inputPassword, string storedHash)
        {
            var inputHash = inputPassword;
            return inputHash == storedHash;
        }

        /// <summary>
        /// Создает резервную копию БД
        /// </summary>
        public bool BackupDatabase(string backupPath)
        {
            try
            {
                var dbPath = AppDbContext.GetDatabasePath();
                File.Copy(dbPath, backupPath, true);
                Console.WriteLine($"Резервная копия создана: {backupPath}");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка создания резервной копии: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Закрывает соединение с БД
        /// </summary>
        public void Dispose()
        {
            _context?.Dispose();
        }

        #endregion

        #region Примеры использования

        public void DemoUsage()
        {
            Console.WriteLine("=== Демонстрация работы с настройками ===");

            // 1. Создаем или получаем аккаунт
            var account = _context.Accounts.FirstOrDefault(a => a.Login == "testuser");
            if (account == null)
            {
                account = new Account
                {
                    Login = "testuser",
                    Password = "test123"
                };
                _context.Accounts.Add(account);
                _context.SaveChanges();
            }

            // 2. Создаем настройки по умолчанию если их нет
            CreateDefaultSettingsForAccount(account.Id);

            // 3. Получаем настройки
            var settings = GetSettings("testuser");
            if (settings != null)
            {
                Console.WriteLine($"ConstantDelay: {settings.ConstantDelay}");
                Console.WriteLine($"ReadProfile: {settings.ReadProfile}");

                if (settings.ReadProfileSettings != null &&
                    settings.ReadProfileSettings.ContainsKey(Scroll_model.Profile.DeepReader))
                {
                    var fastReaderSettings = settings.ReadProfileSettings[Scroll_model.Profile.DeepReader];
                    Console.WriteLine($"FastReader ChanceOfRegression: {fastReaderSettings.ChanceOfRegression}%");
                }
            }

            // 4. Обновляем настройки
            settings.ConstantDelay = 2000;
            settings.ReadProfile = Scroll_model.Profile.DeepReader;

            // Обновляем настройки профиля
            var newProfileSettings = new Models.ProfileSettings
            {
                ChanceOfRegression = 40,
                MinMaxScrollStep = 120,
                MinMaxScrollDuration = 900,
                MinMaxPauseAfterScrolling = 700
            };

            UpdateProfileSetting("testuser", Scroll_model.Profile.DeepReader, newProfileSettings);

            // 5. Сохраняем обновленные настройки
            SaveSettings("testuser", settings);

            Console.WriteLine("Демонстрация завершена.");
        }

        #endregion
    }
}
