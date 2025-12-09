using Microsoft.Extensions.DependencyInjection;
using SGPL.App.Infra;


namespace SGPL.App
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ConfigureDI.ConfigureServices();

            var mainForm = ConfigureDI.serviceProvider!.GetRequiredService<MainForm>();

            Application.Run(mainForm);
        }
    }
}