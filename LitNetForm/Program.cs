using LitPulse.Data.Database.Services;
using LitPulse.Forms;

namespace LitPulse
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Проверка базы данных аккаунтов
            var dbService = new DatabaseService();
            dbService.InitializeDatabase();

            Application.Run(new MainForm());
        }
    }
}