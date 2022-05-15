using azuremyst.contexts;
using azuremyst.extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Collections;
using System.Reflection;

namespace azuremyst.factories
{
    sealed class DesignTimeDefaultDbContextFactory : IDesignTimeDbContextFactory<DefaultDbContext>
    {
        public DefaultDbContext CreateDbContext(string[] args)
        {
            return Task.Run(async () =>
            {
                foreach (DictionaryEntry environmentVariable in Environment.GetEnvironmentVariables())
                {
                    if (environmentVariable.Key.ToString()!.Contains("APPLICATION") && environmentVariable.Value!.ToString()!.StartsWith('/'))
                        Environment.SetEnvironmentVariable(environmentVariable.Key.ToString()!, await File.ReadAllTextAsync(environmentVariable.Value.ToString()!));
                }

                var configuration = new ConfigurationBuilder()
                    .AddEnvironmentVariables()
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
                    .Build();

                var connection = await configuration.BuildDefaultConnectionStringAsync();
                var optionsBuilder = new DbContextOptionsBuilder<DefaultDbContext>()
                    .UseMySql(connection, ServerVersion.AutoDetect(connection), x =>
                    {
                        x.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name);
                    });
                return new DefaultDbContext(optionsBuilder.Options);
            }).Result;
        }
    }
}
