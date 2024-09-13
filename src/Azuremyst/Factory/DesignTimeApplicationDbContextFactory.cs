using Azuremyst.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Azuremyst.Factories;

public class DesignTimeApplicationDbContextFactory
    : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseMySQL(
            "Server=localhost;Database=azuremyst;Uid=;Pwd=;",
            b => b.MigrationsAssembly("Azuremyst")
        );

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
