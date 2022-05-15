using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace azuremyst.Migrations.AuthDb
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "account",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Identifier")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    gmlevel = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    sessionkey = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    v = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    s = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    email = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    joindate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "current_timestamp()"),
                    lockedIp = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, defaultValueSql: "'0.0.0.0'", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    failed_logins = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    locked = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    last_module = table.Column<string>(type: "char(32)", fixedLength: true, maxLength: 32, nullable: true, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    module_day = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    active_realm_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    expansion = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    mutetime = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false),
                    locale = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    os = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: false, defaultValueSql: "'0'", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    token = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    flags = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account", x => x.id);
                },
                comment: "Account System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "account_banned",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    account_id = table.Column<int>(type: "int(11)", nullable: false, comment: "Account id"),
                    banned_at = table.Column<long>(type: "bigint(40)", nullable: false),
                    expires_at = table.Column<long>(type: "bigint(40)", nullable: false),
                    banned_by = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    unbanned_at = table.Column<long>(type: "bigint(40)", nullable: false),
                    unbanned_by = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    reason = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    active = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account_banned", x => x.id);
                },
                comment: "Ban List")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "account_logons",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    accountId = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    ip = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    loginTime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "current_timestamp()"),
                    loginSource = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account_logons", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "account_raf",
                columns: table => new
                {
                    referrer = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    referred = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.referrer, x.referred })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "antispam_blacklist",
                columns: table => new
                {
                    @string = table.Column<string>(name: "string", type: "varchar(64)", maxLength: 64, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.@string);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "antispam_replacement",
                columns: table => new
                {
                    from = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    to = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.from);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "antispam_unicode_replacement",
                columns: table => new
                {
                    from = table.Column<uint>(type: "mediumint(5) unsigned", nullable: false, defaultValueSql: "'0'"),
                    to = table.Column<uint>(type: "mediumint(5) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.from);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "ip_banned",
                columns: table => new
                {
                    ip = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, defaultValueSql: "'0.0.0.0'", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    banned_at = table.Column<long>(type: "bigint(40)", nullable: false),
                    expires_at = table.Column<long>(type: "bigint(40)", nullable: false),
                    banned_by = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, defaultValueSql: "'[Console]'", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    reason = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "'no reason'", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.ip, x.banned_at })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Banned IPs")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "realmcharacters",
                columns: table => new
                {
                    realmid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    acctid = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    numchars = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.realmid, x.acctid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Realm Character Tracker")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "realmd_db_version",
                columns: table => new
                {
                    required_s2433_01_realmd_anticheat = table.Column<ulong>(type: "bit(1)", nullable: true)
                },
                constraints: table =>
                {
                },
                comment: "Last applied sql update to DB")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "realmlist",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    address = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, defaultValueSql: "'127.0.0.1'", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    port = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "'8085'"),
                    icon = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    realmflags = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'2'", comment: "Supported masks: 0x1 (invalid, not show in realm list), 0x2 (offline, set by mangosd), 0x4 (show version and build), 0x20 (new players), 0x40 (recommended)"),
                    timezone = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    allowedSecurityLevel = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    population = table.Column<float>(type: "float unsigned", nullable: false),
                    realmbuilds = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_realmlist", x => x.id);
                },
                comment: "Realm System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "system_fingerprint_usage",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fingerprint = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    account = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    ip = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    realm = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    time = table.Column<DateTime>(type: "datetime", nullable: true),
                    architecture = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    cputype = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    activecpus = table.Column<uint>(type: "int(10) unsigned", nullable: true),
                    totalcpus = table.Column<uint>(type: "int(10) unsigned", nullable: true),
                    pagesize = table.Column<uint>(type: "int(10) unsigned", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_system_fingerprint_usage", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "uptime",
                columns: table => new
                {
                    realmid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    starttime = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    startstring = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    uptime = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    maxplayers = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.realmid, x.starttime })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Uptime system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateIndex(
                name: "idx_gmlevel",
                table: "account",
                column: "gmlevel");

            migrationBuilder.CreateIndex(
                name: "idx_username",
                table: "account",
                column: "username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "acctid",
                table: "realmcharacters",
                column: "acctid");

            migrationBuilder.CreateIndex(
                name: "idx_name",
                table: "realmlist",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "account",
                table: "system_fingerprint_usage",
                column: "account");

            migrationBuilder.CreateIndex(
                name: "fingerprint",
                table: "system_fingerprint_usage",
                column: "fingerprint");

            migrationBuilder.CreateIndex(
                name: "ip",
                table: "system_fingerprint_usage",
                column: "ip");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.DropTable(
                name: "account_banned");

            migrationBuilder.DropTable(
                name: "account_logons");

            migrationBuilder.DropTable(
                name: "account_raf");

            migrationBuilder.DropTable(
                name: "antispam_blacklist");

            migrationBuilder.DropTable(
                name: "antispam_replacement");

            migrationBuilder.DropTable(
                name: "antispam_unicode_replacement");

            migrationBuilder.DropTable(
                name: "ip_banned");

            migrationBuilder.DropTable(
                name: "realmcharacters");

            migrationBuilder.DropTable(
                name: "realmd_db_version");

            migrationBuilder.DropTable(
                name: "realmlist");

            migrationBuilder.DropTable(
                name: "system_fingerprint_usage");

            migrationBuilder.DropTable(
                name: "uptime");
        }
    }
}
