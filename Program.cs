using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PlayStation.Models;
using PlayStation.Presentation;
using PlayStation.Infrastructure.Repos.Repository;
using Microsoft.EntityFrameworkCore.Design;
using PlayStation.Application.Services;

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
            ApplicationConfiguration.Initialize();

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration Configuration = builder.Build();
            var services = new ServiceCollection();
            
            // Register DbContext
            services.AddDbContext<PSManagementDbContext>(o=>o.UseSqlServer(Configuration.GetConnectionString("ZezoSqlServer")).UseLazyLoadingProxies());
            
            // Register Repository
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            //Register services
            services.AddTransient<CafeService>();
            services.AddTransient<DeviceService>();
            services.AddTransient<ExpensesService>();
            services.AddTransient<SessionService>();
            services.AddTransient<UserService>();

            // Register Presentation
            services.AddTransient<AllDevices>();
            services.AddTransient<BaseForm>();
            services.AddTransient<Cafetria>();
            services.AddTransient<DeviceManagment>();
            services.AddTransient<ExpensesForm>();
            services.AddTransient<Home>();
            services.AddTransient<LogIn>();
            services.AddTransient<SingleDevice>();
            services.AddTransient<UpdateDevice>();
            services.AddTransient<UpdateItem>();
            services.AddTransient<UpdateUser>();
            services.AddTransient<UserManagement>();


            ServiceProvider serviceProvider = services.BuildServiceProvider();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = serviceProvider.GetRequiredService<Home>();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            System.Windows.Forms.Application.Run(mainForm);
        }

    }
}