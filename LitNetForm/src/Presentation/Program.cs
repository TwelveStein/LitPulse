using Core;
using Infrastructure;
using Infrastructure.Database;
using LitPulse.Forms;
using Microsoft.Extensions.DependencyInjection;

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

            var services = new ServiceCollection();
            services.AddPresentation();
            services.AddCore();
            services.AddInfrastructure();
            
            using var provider = services.BuildServiceProvider();
            
            using (var scope = provider.CreateAsyncScope())
            {
                DatabaseInitializer dbInitializer = scope.ServiceProvider.GetRequiredService<DatabaseInitializer>();
                dbInitializer.Initialize();
            }

            MainForm mainForm = provider.GetRequiredService<MainForm>();
            
            Application.Run(mainForm);
        }
    }
}