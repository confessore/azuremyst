using Azuremyst.Models;
using Microsoft.EntityFrameworkCore;

namespace Azuremyst.Contexts;

public partial class ApplicationDbContext
{
    public virtual DbSet<User> Users { get; set; }

    protected void AddUserModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("Users");
    }
}
