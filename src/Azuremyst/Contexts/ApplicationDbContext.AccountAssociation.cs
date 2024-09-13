using Azuremyst.Models;
using Microsoft.EntityFrameworkCore;

namespace Azuremyst.Contexts;

public partial class ApplicationDbContext
{
    public virtual DbSet<AccountAssociation> AccountAssociations { get; set; }

    protected void AddAccountAssociationModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountAssociation>().ToTable("AccountAssociations");
    }
}
