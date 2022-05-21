using azuremyst.models.logs;
using Microsoft.EntityFrameworkCore;

namespace azuremyst.contexts
{
    public partial class LogsDbContext : DbContext
    {
        public LogsDbContext(DbContextOptions<LogsDbContext> options)
            : base(options) { }

        public virtual DbSet<LogsAnticheat>? LogsAnticheats { get; set; } = null!;
        public virtual DbSet<LogsDbVersion>? LogsDbVersions { get; set; } = null!;
        public virtual DbSet<LogsSpamdetect>? LogsSpamdetects { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<LogsAnticheat>(entity =>
            {
                entity.ToTable("logs_anticheat");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Account, "account");

                entity.HasIndex(e => e.Ip, "ip");

                entity.HasIndex(e => e.Realm, "realm");

                entity.HasIndex(e => e.Time, "time");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Account)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("account");

                entity.Property(e => e.ActionMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("actionMask");

                entity.Property(e => e.Fingerprint)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("fingerprint");

                entity.Property(e => e.Info)
                    .HasMaxLength(512)
                    .HasColumnName("info");

                entity.Property(e => e.Ip)
                    .HasMaxLength(16)
                    .HasColumnName("ip");

                entity.Property(e => e.Player)
                    .HasMaxLength(32)
                    .HasColumnName("player");

                entity.Property(e => e.Realm)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("realm");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<LogsDbVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("logs_db_version");

                entity.HasComment("Last applied sql update to DB")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.RequiredS243301LogsAnticheat)
                    .HasColumnType("bit(1)")
                    .HasColumnName("required_s2433_01_logs_anticheat");
            });

            modelBuilder.Entity<LogsSpamdetect>(entity =>
            {
                entity.ToTable("logs_spamdetect");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.FromGuid, "guid");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("int(11)")
                    .HasColumnName("accountId")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comment)
                    .HasMaxLength(8192)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FromFingerprint)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("fromFingerprint");

                entity.Property(e => e.FromGuid)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("fromGuid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FromIp)
                    .HasMaxLength(16)
                    .HasColumnName("fromIP");

                entity.Property(e => e.Realm)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("realm");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasColumnName("time")
                    .HasDefaultValueSql("current_timestamp()");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
