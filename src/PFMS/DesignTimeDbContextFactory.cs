using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PFMS.Persistence;
using System.IO;
using System.Reflection;

namespace PFMS
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var assembly = Assembly.GetAssembly(typeof(Program));
            var assemblyName = assembly.GetName().Name;

            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddXmlFile("appsettings.xml", optional: false, reloadOnChange: true);

            var configuration = configurationBuilder.Build();

            var builder = new DbContextOptionsBuilder<DatabaseContext>();

            builder.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly(assemblyName);
                });

            return new DatabaseContext(builder.Options);
        }
    }
}
