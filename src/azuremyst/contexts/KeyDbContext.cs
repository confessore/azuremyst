using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace azuremyst.contexts
{
    public class KeyDbContext : DbContext, IDataProtectionKeyContext
    {
        public KeyDbContext(DbContextOptions<KeyDbContext> options)
            : base(options) { }

#pragma warning disable CS8766 // Nullability of reference types in return type doesn't match implicitly implemented member (possibly because of nullability attributes).
        public virtual DbSet<DataProtectionKey>? DataProtectionKeys { get; set; }
#pragma warning restore CS8766 // Nullability of reference types in return type doesn't match implicitly implemented member (possibly because of nullability attributes).
    }
}
