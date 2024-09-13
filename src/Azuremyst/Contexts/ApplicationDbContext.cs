using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Azuremyst.Contexts
{
    public partial class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : DbContext(options),
            IDataProtectionKeyContext
    {
        public virtual DbSet<DataProtectionKey> DataProtectionKeys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            AddUserModel(modelBuilder);
            AddRoleModel(modelBuilder);
            AddAccountAssociationModel(modelBuilder);
        }
    }
}
