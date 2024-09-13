using Azuremyst.Models;
using Microsoft.EntityFrameworkCore;

namespace Azuremyst.Contexts;

public partial class ApplicationDbContext
{
    public virtual DbSet<Role> Roles { get; set; }

    protected void AddRoleModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().ToTable("Roles");
    }
}
