using azuremyst.models.abstractions;
using azuremyst.models.enums;
using azuremyst.models.roles;
using azuremyst.models.tokens;
using azuremyst.models.users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace azuremyst.contexts
{
    public class DefaultDbContext : IdentityDbContext<User, Role, string>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
            : base(options) { }

        new public virtual DbSet<User>? Users { get; set; }
        public virtual DbSet<Token>? Tokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var keysProperties = modelBuilder.Model.GetEntityTypes().Select(x => x.FindPrimaryKey()).SelectMany(x => x!.Properties);

            foreach (var property in keysProperties)
                property.ValueGenerated = ValueGenerated.OnAdd;

            modelBuilder.Entity<User>()
                .ToTable("Users")
                .HasDiscriminator<UserType>(nameof(UserType))
                .HasValue<DefaultUser>(UserType.Default)
                .IsComplete();

            modelBuilder.Entity<Role>()
                .ToTable("Roles")
                .HasDiscriminator<RoleType>(nameof(RoleType))
                .HasValue<DefaultRole>(RoleType.Default)
                .IsComplete();

            modelBuilder.Entity<Token>()
                .ToTable("Tokens")
                .HasDiscriminator<TokenType>(nameof(TokenType))
                .HasValue<DefaultToken>(TokenType.Default)
                .HasValue<AuthenticationToken>(TokenType.Authentication)
                .HasValue<RefreshToken>(TokenType.Refresh)
                .IsComplete();
        }
    }
}
