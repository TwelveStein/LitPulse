using LitNetForm.Data;
using LitPulse.Bots;
using LitPulse.Data.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using static LitPulse.Bots.Scroll_model;

namespace LitPulse.Data.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountSettings> AccountSettings { get; set; }
        public DbSet<ProfileSettings> ProfileSettings { get; set; }

        // Путь к файлу БД
        private const string DatabasePath = "accounts.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Data Source={DatabasePath}");

                // Логирование SQL (только для отладки)
#if DEBUG
                optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
                optionsBuilder.EnableSensitiveDataLogging();
#endif
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Настройка таблицы Accounts
            modelBuilder.Entity<Account>(entity =>
            {
                // Уникальный индекс для логина
                entity.HasIndex(a => a.Login)
                      .IsUnique();
            });

            // Настройка таблицы AccountSettings
            modelBuilder.Entity<AccountSettings>(entity =>
            {
                // Уникальный индекс для связи с аккаунтом
                entity.HasIndex(a => a.AccountId).IsUnique();

                // Связь один-к-одному с Account
                entity.HasOne(a => a.Account)
                      .WithOne()
                      .HasForeignKey<AccountSettings>(a => a.AccountId)
                      .OnDelete(DeleteBehavior.Cascade);

                // Значения по умолчанию
                entity.Property(a => a.CreatedAt)
                      .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(a => a.UpdatedAt)
                      .HasDefaultValueSql("CURRENT_TIMESTAMP")
                      .ValueGeneratedOnAddOrUpdate();

                // Установка значений по умолчанию для булевых полей
                entity.Property(a => a.ReadBook).HasDefaultValue(true);
                entity.Property(a => a.LikeTheBook).HasDefaultValue(true);
                entity.Property(a => a.ConstantDelay).HasDefaultValue(1000);
                entity.Property(a => a.FloatingIncrementalDelay).HasDefaultValue(500);
                entity.Property(a => a.ReadProfile).HasDefaultValue(Scroll_model.Profile.DeepReader);
            });

            // Настройка таблицы ProfileSettings
            modelBuilder.Entity<ProfileSettings>(entity =>
            {
                // Композитный уникальный ключ: AccountSettingsId + ProfileType
                entity.HasIndex(ps => new { ps.AccountSettingsId, ps.ProfileType })
                      .IsUnique();

                // Связь с AccountSettings
                entity.HasOne(ps => ps.AccountSettings)
                      .WithMany(a => a.ProfileSettings)
                      .HasForeignKey(ps => ps.AccountSettingsId)
                      .OnDelete(DeleteBehavior.Cascade);

                // Значения по умолчанию для разных профилей
                entity.HasData(
                // Значения по умолчанию будут добавляться при создании
                // через метод InitializeProfileSettings
                );
            });
        }

        // Метод для получения пути к файлу БД
        public static string GetDatabasePath() => DatabasePath;
    }
}
