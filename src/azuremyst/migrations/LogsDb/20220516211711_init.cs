using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace azuremyst.Migrations.LogsDb
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "logs_anticheat",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    time = table.Column<DateTime>(type: "datetime", nullable: true),
                    realm = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    account = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    ip = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    fingerprint = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    actionMask = table.Column<uint>(type: "int(10) unsigned", nullable: true),
                    player = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    info = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logs_anticheat", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "logs_db_version",
                columns: table => new
                {
                    required_s2433_01_logs_anticheat = table.Column<ulong>(type: "bit(1)", nullable: true)
                },
                constraints: table =>
                {
                },
                comment: "Last applied sql update to DB")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "logs_spamdetect",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    time = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "current_timestamp()"),
                    realm = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    accountId = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'0'"),
                    fromGuid = table.Column<ulong>(type: "bigint(20) unsigned", nullable: true, defaultValueSql: "'0'"),
                    fromIP = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    fromFingerprint = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    comment = table.Column<string>(type: "varchar(8192)", maxLength: 8192, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logs_spamdetect", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateIndex(
                name: "account",
                table: "logs_anticheat",
                column: "account");

            migrationBuilder.CreateIndex(
                name: "ip",
                table: "logs_anticheat",
                column: "ip");

            migrationBuilder.CreateIndex(
                name: "realm",
                table: "logs_anticheat",
                column: "realm");

            migrationBuilder.CreateIndex(
                name: "time",
                table: "logs_anticheat",
                column: "time");

            migrationBuilder.CreateIndex(
                name: "guid",
                table: "logs_spamdetect",
                column: "fromGuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "logs_anticheat");

            migrationBuilder.DropTable(
                name: "logs_db_version");

            migrationBuilder.DropTable(
                name: "logs_spamdetect");
        }
    }
}
