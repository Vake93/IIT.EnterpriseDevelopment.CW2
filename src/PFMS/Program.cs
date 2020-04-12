using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PFMS.Configurations;
using PFMS.Domain;
using PFMS.Persistence;
using PFMS.Services;
using PFMS.Views;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PFMS
{
    public static class Program
    {
        private static readonly IServiceProvider _serviceProvider;
        private static readonly IConfiguration _configuration;

        static Program()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddXmlFile("appsettings.xml", optional: false, reloadOnChange: true);

            _configuration = configurationBuilder.Build();

            var builder = new ContainerBuilder();

            builder.Populate(ConfigureServices());

            builder.RegisterModule<ViewModule>();
            builder.RegisterModule<ServiceModule>();

            _serviceProvider = new AutofacServiceProvider(builder.Build());
        }

        private static IServiceCollection ConfigureServices()
        {
            var assembly = Assembly.GetAssembly(typeof(Program));
            var assemblyName = assembly.GetName().Name;

            return new ServiceCollection()
                .AddAutofac()
                .AddAutoMapper(
                    Assembly.GetAssembly(typeof(Program))
                )
                .AddDbContext<DatabaseContext>(options =>
                {
                    options.UseSqlServer(
                        _configuration.GetConnectionString("DefaultConnection"),
                        sqlServerOptionsAction: sqlOptions =>
                        {
                            sqlOptions.MigrationsAssembly(assemblyName);
                        });
                })
                .Configure<StyleConfiguration>(_configuration.GetSection("Style"));
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var scope = _serviceProvider.CreateScope())
            {
                var services = scope.ServiceProvider;

                services.GetRequiredService<FrmSplash>().Show();

                Application.Run();
            }
        }
    }
}
