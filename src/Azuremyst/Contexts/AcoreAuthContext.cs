using Azuremyst.Models.Acore.Auth;
using Microsoft.EntityFrameworkCore;

namespace Azuremyst.Contexts;

public partial class AcoreAuthContext : DbContext
{
    public AcoreAuthContext() { }

    public AcoreAuthContext(DbContextOptions<AcoreAuthContext> options)
        : base(options) { }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountAccess> AccountAccesses { get; set; }

    public virtual DbSet<AccountBanned> AccountBanneds { get; set; }

    public virtual DbSet<AccountMuted> AccountMuteds { get; set; }

    public virtual DbSet<Autobroadcast> Autobroadcasts { get; set; }

    public virtual DbSet<BuildInfo> BuildInfos { get; set; }

    public virtual DbSet<IpBanned> IpBanneds { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<LogsIpAction> LogsIpActions { get; set; }

    public virtual DbSet<Motd> Motds { get; set; }

    public virtual DbSet<Realmcharacter> Realmcharacters { get; set; }

    public virtual DbSet<Realmlist> Realmlists { get; set; }

    public virtual DbSet<SecretDigest> SecretDigests { get; set; }

    public virtual DbSet<Models.Acore.Auth.Update> Updates { get; set; }

    public virtual DbSet<Models.Acore.Auth.UpdatesInclude> UpdatesIncludes { get; set; }

    public virtual DbSet<Uptime> Uptimes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("account", tb => tb.HasComment("Account System"));

            entity.HasIndex(e => e.Username, "idx_username").IsUnique();

            entity.Property(e => e.Id).HasComment("Identifier").HasColumnName("id");
            entity
                .Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("email");
            entity.Property(e => e.Expansion).HasDefaultValueSql("'2'").HasColumnName("expansion");
            entity.Property(e => e.FailedLogins).HasColumnName("failed_logins");
            entity
                .Property(e => e.Joindate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("joindate");
            entity
                .Property(e => e.LastAttemptIp)
                .HasMaxLength(15)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("last_attempt_ip");
            entity
                .Property(e => e.LastIp)
                .HasMaxLength(15)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("last_ip");
            entity
                .Property(e => e.LastLogin)
                .HasColumnType("timestamp")
                .HasColumnName("last_login");
            entity.Property(e => e.Locale).HasColumnName("locale");
            entity
                .Property(e => e.LockCountry)
                .HasMaxLength(2)
                .HasDefaultValueSql("'00'")
                .HasColumnName("lock_country");
            entity.Property(e => e.Locked).HasColumnName("locked");
            entity
                .Property(e => e.Muteby)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("muteby");
            entity
                .Property(e => e.Mutereason)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("mutereason");
            entity.Property(e => e.Mutetime).HasColumnName("mutetime");
            entity.Property(e => e.Online).HasColumnName("online");
            entity.Property(e => e.Os).HasMaxLength(3).HasDefaultValueSql("''").HasColumnName("os");
            entity.Property(e => e.Recruiter).HasColumnName("recruiter");
            entity
                .Property(e => e.RegMail)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("reg_mail");
            entity.Property(e => e.Salt).HasMaxLength(32).IsFixedLength().HasColumnName("salt");
            entity
                .Property(e => e.SessionKey)
                .HasMaxLength(40)
                .IsFixedLength()
                .HasColumnName("session_key");
            entity.Property(e => e.Totaltime).HasColumnName("totaltime");
            entity.Property(e => e.TotpSecret).HasMaxLength(128).HasColumnName("totp_secret");
            entity
                .Property(e => e.Username)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
            entity
                .Property(e => e.Verifier)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("verifier");
        });

        modelBuilder.Entity<AccountAccess>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.RealmId }).HasName("PRIMARY");

            entity.ToTable("account_access");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RealmId).HasDefaultValueSql("'-1'").HasColumnName("RealmID");
            entity
                .Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment");
            entity.Property(e => e.Gmlevel).HasColumnName("gmlevel");
        });

        modelBuilder.Entity<AccountBanned>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Bandate }).HasName("PRIMARY");

            entity.ToTable("account_banned", tb => tb.HasComment("Ban List"));

            entity.Property(e => e.Id).HasComment("Account id").HasColumnName("id");
            entity.Property(e => e.Bandate).HasColumnName("bandate");
            entity.Property(e => e.Active).HasDefaultValueSql("'1'").HasColumnName("active");
            entity.Property(e => e.Bannedby).HasMaxLength(50).HasColumnName("bannedby");
            entity.Property(e => e.Banreason).HasMaxLength(255).HasColumnName("banreason");
            entity.Property(e => e.Unbandate).HasColumnName("unbandate");
        });

        modelBuilder.Entity<AccountMuted>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Mutedate }).HasName("PRIMARY");

            entity.ToTable("account_muted", tb => tb.HasComment("mute List"));

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Mutedate).HasColumnName("mutedate");
            entity.Property(e => e.Mutedby).HasMaxLength(50).HasColumnName("mutedby");
            entity.Property(e => e.Mutereason).HasMaxLength(255).HasColumnName("mutereason");
            entity.Property(e => e.Mutetime).HasColumnName("mutetime");
        });

        modelBuilder.Entity<Autobroadcast>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Realmid }).HasName("PRIMARY");

            entity.ToTable("autobroadcast");

            entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");
            entity.Property(e => e.Realmid).HasDefaultValueSql("'-1'").HasColumnName("realmid");
            entity.Property(e => e.Text).HasColumnName("text");
            entity.Property(e => e.Weight).HasDefaultValueSql("'1'").HasColumnName("weight");
        });

        modelBuilder.Entity<BuildInfo>(entity =>
        {
            entity.HasKey(e => e.Build).HasName("PRIMARY");

            entity.ToTable("build_info");

            entity.Property(e => e.Build).HasColumnName("build");
            entity.Property(e => e.BugfixVersion).HasColumnName("bugfixVersion");
            entity
                .Property(e => e.HotfixVersion)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("hotfixVersion");
            entity.Property(e => e.Mac64AuthSeed).HasMaxLength(32).HasColumnName("mac64AuthSeed");
            entity
                .Property(e => e.MacChecksumSeed)
                .HasMaxLength(40)
                .HasColumnName("macChecksumSeed");
            entity.Property(e => e.MajorVersion).HasColumnName("majorVersion");
            entity.Property(e => e.MinorVersion).HasColumnName("minorVersion");
            entity.Property(e => e.Win64AuthSeed).HasMaxLength(32).HasColumnName("win64AuthSeed");
            entity.Property(e => e.WinAuthSeed).HasMaxLength(32).HasColumnName("winAuthSeed");
            entity
                .Property(e => e.WinChecksumSeed)
                .HasMaxLength(40)
                .HasColumnName("winChecksumSeed");
        });

        modelBuilder.Entity<IpBanned>(entity =>
        {
            entity.HasKey(e => new { e.Ip, e.Bandate }).HasName("PRIMARY");

            entity.ToTable("ip_banned", tb => tb.HasComment("Banned IPs"));

            entity
                .Property(e => e.Ip)
                .HasMaxLength(15)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("ip");
            entity.Property(e => e.Bandate).HasColumnName("bandate");
            entity
                .Property(e => e.Bannedby)
                .HasMaxLength(50)
                .HasDefaultValueSql("'[Console]'")
                .HasColumnName("bannedby");
            entity
                .Property(e => e.Banreason)
                .HasMaxLength(255)
                .HasDefaultValueSql("'no reason'")
                .HasColumnName("banreason");
            entity.Property(e => e.Unbandate).HasColumnName("unbandate");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasNoKey().ToTable("logs");

            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Realm).HasColumnName("realm");
            entity.Property(e => e.String).HasColumnType("text").HasColumnName("string");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.Type).HasMaxLength(250).HasColumnName("type");
        });

        modelBuilder.Entity<LogsIpAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable(
                "logs_ip_actions",
                tb => tb.HasComment("Used to log ips of individual actions")
            );

            entity.Property(e => e.Id).HasComment("Unique Identifier").HasColumnName("id");
            entity.Property(e => e.AccountId).HasComment("Account ID").HasColumnName("account_id");
            entity
                .Property(e => e.CharacterGuid)
                .HasComment("Character Guid")
                .HasColumnName("character_guid");
            entity
                .Property(e => e.Comment)
                .HasComment("Allows users to add a comment")
                .HasColumnType("text")
                .HasColumnName("comment");
            entity
                .Property(e => e.Ip)
                .HasMaxLength(15)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("ip");
            entity
                .Property(e => e.Systemnote)
                .HasComment("Notes inserted by system")
                .HasColumnType("text")
                .HasColumnName("systemnote");
            entity
                .Property(e => e.Time)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("Timestamp")
                .HasColumnType("timestamp")
                .HasColumnName("time");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Unixtime).HasComment("Unixtime").HasColumnName("unixtime");
        });

        modelBuilder.Entity<Motd>(entity =>
        {
            entity.HasKey(e => e.Realmid).HasName("PRIMARY");

            entity.ToTable("motd");

            entity.Property(e => e.Realmid).HasColumnName("realmid");
            entity.Property(e => e.Text).HasColumnName("text");
        });

        modelBuilder.Entity<Realmcharacter>(entity =>
        {
            entity.HasKey(e => new { e.Realmid, e.Acctid }).HasName("PRIMARY");

            entity.ToTable("realmcharacters", tb => tb.HasComment("Realm Character Tracker"));

            entity.HasIndex(e => e.Acctid, "acctid");

            entity.Property(e => e.Realmid).HasColumnName("realmid");
            entity.Property(e => e.Acctid).HasColumnName("acctid");
            entity.Property(e => e.Numchars).HasColumnName("numchars");
        });

        modelBuilder.Entity<Realmlist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("realmlist", tb => tb.HasComment("Realm System"));

            entity.HasIndex(e => e.Name, "idx_name").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity
                .Property(e => e.Address)
                .HasMaxLength(255)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("address");
            entity.Property(e => e.AllowedSecurityLevel).HasColumnName("allowedSecurityLevel");
            entity.Property(e => e.Flag).HasDefaultValueSql("'2'").HasColumnName("flag");
            entity
                .Property(e => e.Gamebuild)
                .HasDefaultValueSql("'12340'")
                .HasColumnName("gamebuild");
            entity.Property(e => e.Icon).HasColumnName("icon");
            entity
                .Property(e => e.LocalAddress)
                .HasMaxLength(255)
                .HasDefaultValueSql("'127.0.0.1'")
                .HasColumnName("localAddress");
            entity
                .Property(e => e.LocalSubnetMask)
                .HasMaxLength(255)
                .HasDefaultValueSql("'255.255.255.0'")
                .HasColumnName("localSubnetMask");
            entity
                .Property(e => e.Name)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Population).HasColumnName("population");
            entity.Property(e => e.Port).HasDefaultValueSql("'8085'").HasColumnName("port");
            entity.Property(e => e.Timezone).HasColumnName("timezone");
        });

        modelBuilder.Entity<SecretDigest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("secret_digest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Digest).HasMaxLength(100).HasColumnName("digest");
        });

        modelBuilder.Entity<Models.Acore.Auth.Update>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PRIMARY");

            entity.ToTable(
                "updates",
                tb => tb.HasComment("List of all applied updates in this database.")
            );

            entity
                .Property(e => e.Name)
                .HasMaxLength(200)
                .HasComment("filename with extension of the update.")
                .HasColumnName("name");
            entity
                .Property(e => e.Hash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasComment("sha1 hash of the sql file.")
                .HasColumnName("hash");
            entity
                .Property(e => e.Speed)
                .HasComment("time the query takes to apply in ms.")
                .HasColumnName("speed");
            entity
                .Property(e => e.State)
                .HasDefaultValueSql("'RELEASED'")
                .HasComment("defines if an update is released or archived.")
                .HasColumnType("enum('RELEASED','CUSTOM','MODULE','ARCHIVED')")
                .HasColumnName("state");
            entity
                .Property(e => e.Timestamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("timestamp when the query was applied.")
                .HasColumnType("timestamp")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<Models.Acore.Auth.UpdatesInclude>(entity =>
        {
            entity.HasKey(e => e.Path).HasName("PRIMARY");

            entity.ToTable(
                "updates_include",
                tb => tb.HasComment("List of directories where we want to include sql updates.")
            );

            entity
                .Property(e => e.Path)
                .HasMaxLength(200)
                .HasComment("directory to include. $ means relative to the source directory.")
                .HasColumnName("path");
            entity
                .Property(e => e.State)
                .HasDefaultValueSql("'RELEASED'")
                .HasComment("defines if the directory contains released or archived updates.")
                .HasColumnType("enum('RELEASED','ARCHIVED','CUSTOM')")
                .HasColumnName("state");
        });

        modelBuilder.Entity<Uptime>(entity =>
        {
            entity.HasKey(e => new { e.Realmid, e.Starttime }).HasName("PRIMARY");

            entity.ToTable("uptime", tb => tb.HasComment("Uptime system"));

            entity.Property(e => e.Realmid).HasColumnName("realmid");
            entity.Property(e => e.Starttime).HasColumnName("starttime");
            entity.Property(e => e.Maxplayers).HasColumnName("maxplayers");
            entity
                .Property(e => e.Revision)
                .HasMaxLength(255)
                .HasDefaultValueSql("'AzerothCore'")
                .HasColumnName("revision");
            entity.Property(e => e.Uptime1).HasColumnName("uptime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
