using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using azuremyst.models.realmd;

namespace azuremyst.contexts
{
    public partial class AuthDbContext : DbContext
    {

        public AuthDbContext(DbContextOptions<AuthDbContext> options)
            : base(options) { }

        public virtual DbSet<Account>? Accounts { get; set; } = null!;
        public virtual DbSet<AccountBanned> AccountBanneds { get; set; } = null!;
        public virtual DbSet<AccountLogon> AccountLogons { get; set; } = null!;
        public virtual DbSet<AccountRaf> AccountRafs { get; set; } = null!;
        public virtual DbSet<AntispamBlacklist> AntispamBlacklists { get; set; } = null!;
        public virtual DbSet<AntispamReplacement> AntispamReplacements { get; set; } = null!;
        public virtual DbSet<AntispamUnicodeReplacement> AntispamUnicodeReplacements { get; set; } = null!;
        public virtual DbSet<IpBanned> IpBanneds { get; set; } = null!;
        public virtual DbSet<Realmcharacter> Realmcharacters { get; set; } = null!;
        public virtual DbSet<RealmdDbVersion>? RealmdDbVersions { get; set; } = null!;
        public virtual DbSet<Realmlist>? Realmlists { get; set; } = null!;
        public virtual DbSet<SystemFingerprintUsage> SystemFingerprintUsages { get; set; } = null!;
        public virtual DbSet<Uptime> Uptimes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.HasComment("Account System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Gmlevel, "idx_gmlevel");

                entity.HasIndex(e => e.Username, "idx_username")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id")
                    .HasComment("Identifier");

                entity.Property(e => e.ActiveRealmId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("active_realm_id");

                entity.Property(e => e.Email)
                    .HasColumnType("text")
                    .HasColumnName("email");

                entity.Property(e => e.Expansion)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("expansion");

                entity.Property(e => e.FailedLogins)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("failed_logins");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("flags");

                entity.Property(e => e.Gmlevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("gmlevel");

                entity.Property(e => e.Joindate)
                    .HasColumnType("timestamp")
                    .HasColumnName("joindate")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.LastModule)
                    .HasMaxLength(32)
                    .HasColumnName("last_module")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Locale)
                    .HasMaxLength(4)
                    .HasColumnName("locale")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Locked)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("locked");

                entity.Property(e => e.LockedIp)
                    .HasMaxLength(30)
                    .HasColumnName("lockedIp")
                    .HasDefaultValueSql("'0.0.0.0'");

                entity.Property(e => e.ModuleDay)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("module_day")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mutetime)
                    .HasColumnType("bigint(40) unsigned")
                    .HasColumnName("mutetime");

                entity.Property(e => e.Os)
                    .HasMaxLength(4)
                    .HasColumnName("os")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.S).HasColumnName("s");

                entity.Property(e => e.Sessionkey).HasColumnName("sessionkey");

                entity.Property(e => e.Token)
                    .HasColumnType("text")
                    .HasColumnName("token");

                entity.Property(e => e.Username)
                    .HasMaxLength(32)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.V).HasColumnName("v");
            });

            modelBuilder.Entity<AccountBanned>(entity =>
            {
                entity.ToTable("account_banned");

                entity.HasComment("Ban List")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("int(11)")
                    .HasColumnName("account_id")
                    .HasComment("Account id");

                entity.Property(e => e.Active)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.BannedAt)
                    .HasColumnType("bigint(40)")
                    .HasColumnName("banned_at");

                entity.Property(e => e.BannedBy)
                    .HasMaxLength(50)
                    .HasColumnName("banned_by");

                entity.Property(e => e.ExpiresAt)
                    .HasColumnType("bigint(40)")
                    .HasColumnName("expires_at");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("reason");

                entity.Property(e => e.UnbannedAt)
                    .HasColumnType("bigint(40)")
                    .HasColumnName("unbanned_at");

                entity.Property(e => e.UnbannedBy)
                    .HasMaxLength(50)
                    .HasColumnName("unbanned_by");
            });

            modelBuilder.Entity<AccountLogon>(entity =>
            {
                entity.ToTable("account_logons");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AccountId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("accountId");

                entity.Property(e => e.Ip)
                    .HasMaxLength(30)
                    .HasColumnName("ip");

                entity.Property(e => e.LoginSource)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("loginSource");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("loginTime")
                    .HasDefaultValueSql("current_timestamp()");
            });

            modelBuilder.Entity<AccountRaf>(entity =>
            {
                entity.HasKey(e => new { e.Referrer, e.Referred })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("account_raf");

                entity.Property(e => e.Referrer)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("referrer");

                entity.Property(e => e.Referred)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("referred");
            });

            modelBuilder.Entity<AntispamBlacklist>(entity =>
            {
                entity.HasKey(e => e.String)
                    .HasName("PRIMARY");

                entity.ToTable("antispam_blacklist");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.String)
                    .HasMaxLength(64)
                    .HasColumnName("string");
            });

            modelBuilder.Entity<AntispamReplacement>(entity =>
            {
                entity.HasKey(e => e.From)
                    .HasName("PRIMARY");

                entity.ToTable("antispam_replacement");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.From)
                    .HasMaxLength(32)
                    .HasColumnName("from")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.To)
                    .HasMaxLength(32)
                    .HasColumnName("to")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<AntispamUnicodeReplacement>(entity =>
            {
                entity.HasKey(e => e.From)
                    .HasName("PRIMARY");

                entity.ToTable("antispam_unicode_replacement");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.From)
                    .HasColumnType("mediumint(5) unsigned")
                    .HasColumnName("from")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.To)
                    .HasColumnType("mediumint(5) unsigned")
                    .HasColumnName("to")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<IpBanned>(entity =>
            {
                entity.HasKey(e => new { e.Ip, e.BannedAt })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("ip_banned");

                entity.HasComment("Banned IPs")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Ip)
                    .HasMaxLength(32)
                    .HasColumnName("ip")
                    .HasDefaultValueSql("'0.0.0.0'");

                entity.Property(e => e.BannedAt)
                    .HasColumnType("bigint(40)")
                    .HasColumnName("banned_at");

                entity.Property(e => e.BannedBy)
                    .HasMaxLength(50)
                    .HasColumnName("banned_by")
                    .HasDefaultValueSql("'[Console]'");

                entity.Property(e => e.ExpiresAt)
                    .HasColumnType("bigint(40)")
                    .HasColumnName("expires_at");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("reason")
                    .HasDefaultValueSql("'no reason'");
            });

            modelBuilder.Entity<Realmcharacter>(entity =>
            {
                entity.HasKey(e => new { e.Realmid, e.Acctid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("realmcharacters");

                entity.HasComment("Realm Character Tracker")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Acctid, "acctid");

                entity.Property(e => e.Realmid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("realmid");

                entity.Property(e => e.Acctid)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("acctid");

                entity.Property(e => e.Numchars)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("numchars");
            });

            modelBuilder.Entity<RealmdDbVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("realmd_db_version");

                entity.HasComment("Last applied sql update to DB")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.RequiredS243301RealmdAnticheat)
                    .HasColumnType("bit(1)")
                    .HasColumnName("required_s2433_01_realmd_anticheat");
            });

            modelBuilder.Entity<Realmlist>(entity =>
            {
                entity.ToTable("realmlist");

                entity.HasComment("Realm System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Name, "idx_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(32)
                    .HasColumnName("address")
                    .HasDefaultValueSql("'127.0.0.1'");

                entity.Property(e => e.AllowedSecurityLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("allowedSecurityLevel");

                entity.Property(e => e.Icon)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("icon");

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Population)
                    .HasColumnType("float unsigned")
                    .HasColumnName("population");

                entity.Property(e => e.Port)
                    .HasColumnType("int(11)")
                    .HasColumnName("port")
                    .HasDefaultValueSql("'8085'");

                entity.Property(e => e.Realmbuilds)
                    .HasMaxLength(64)
                    .HasColumnName("realmbuilds")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Realmflags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("realmflags")
                    .HasDefaultValueSql("'2'")
                    .HasComment("Supported masks: 0x1 (invalid, not show in realm list), 0x2 (offline, set by mangosd), 0x4 (show version and build), 0x20 (new players), 0x40 (recommended)");

                entity.Property(e => e.Timezone)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("timezone");
            });

            modelBuilder.Entity<SystemFingerprintUsage>(entity =>
            {
                entity.ToTable("system_fingerprint_usage");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Account, "account");

                entity.HasIndex(e => e.Fingerprint, "fingerprint");

                entity.HasIndex(e => e.Ip, "ip");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Account)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("account");

                entity.Property(e => e.Activecpus)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("activecpus");

                entity.Property(e => e.Architecture)
                    .HasMaxLength(16)
                    .HasColumnName("architecture");

                entity.Property(e => e.Cputype)
                    .HasMaxLength(64)
                    .HasColumnName("cputype");

                entity.Property(e => e.Fingerprint)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("fingerprint");

                entity.Property(e => e.Ip)
                    .HasMaxLength(16)
                    .HasColumnName("ip");

                entity.Property(e => e.Pagesize)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("pagesize");

                entity.Property(e => e.Realm)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("realm");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.Totalcpus)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("totalcpus");
            });

            modelBuilder.Entity<Uptime>(entity =>
            {
                entity.HasKey(e => new { e.Realmid, e.Starttime })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("uptime");

                entity.HasComment("Uptime system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Realmid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("realmid");

                entity.Property(e => e.Starttime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("starttime");

                entity.Property(e => e.Maxplayers)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("maxplayers");

                entity.Property(e => e.Startstring)
                    .HasMaxLength(64)
                    .HasColumnName("startstring")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Uptime1)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("uptime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
