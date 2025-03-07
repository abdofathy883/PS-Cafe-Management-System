using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PlayStation.Models;
using PlayStation.Presentation;
using PlayStation.Infrastructure.Repos.Repository;

namespace PlayStation
{
    internal static class Program
    {


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration Configuration = builder.Build();
            var services = new ServiceCollection();

            services.AddDbContext<PSManagementDbContext>(o=>o.UseSqlServer(Configuration.GetConnectionString("ZezoSqlServer")).UseLazyLoadingProxies());
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<Home>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = serviceProvider.GetRequiredService<Home>();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(mainForm);
        }

    }
}