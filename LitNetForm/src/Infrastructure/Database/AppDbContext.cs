using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Account> Accounts => Set<Account>();
        public DbSet<AccountSettings> AccountSettings => Set<AccountSettings>();
        public DbSet<AccountActionHistory> AccountActionHistories => Set<AccountActionHistory>();
        
        private const string DATABASE_NAME = "accounts.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Путь к файлу БД
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LitPulse");
            Directory.CreateDirectory(folder);
            
            string projectDirectory = Path.Combine(folder, DATABASE_NAME);
            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Data Source={projectDirectory}");

                // Логирование SQL (только для отладки)
#if DEBUG
                optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
                optionsBuilder.EnableSensitiveDataLogging();
#endif
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
