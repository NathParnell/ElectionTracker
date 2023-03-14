using ElectionTracker.Controls;
using ElectionTracker.Forms;
using ElectionTracker.Services;
using ElectionTracker.Services.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace ElectionTracker
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<frmElectionTracker>());
        }
        

        /// <summary>
        /// I used this https://stackoverflow.com/questions/70475830/how-to-use-dependency-injection-in-winforms
        /// </summary>
        /// <returns></returns>
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddSingleton<IUserService, UserService>();
                    services.AddSingleton<IDataService, DataService>();
                    services.AddSingleton<IElectionService, ElectionService>();
                    services.AddTransient<frmElectionTracker>();
                    services.AddTransient<frmCreateElectionGroup>();
                    services.AddTransient<frmRegisterElectionGroup>();
                    services.AddTransient<frmAcceptUserToElectionGroup>();
                    services.AddTransient<frmManageElection>();
                    services.AddTransient<frmCandidates>();
                    services.AddTransient<ctrRegister>();
                    services.AddTransient<ctrLogin>();
                    services.AddTransient<ctrMainMenu>();
                    services.AddTransient<ctrElectionGroupManager>();
                });
        }
    }
}
