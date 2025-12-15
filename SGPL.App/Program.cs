using Microsoft.Extensions.DependencyInjection;
using SGPL.App.Infra;
using SGPL.App.Others;
using System;
using System.Windows.Forms;

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
