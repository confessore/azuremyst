using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Azuremyst.Migrations
{
    /// <inheritdoc />
    public partial class AccountAssociation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "Users",
                type: "longtext",
                nullable: true
            );

            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "Roles",
                type: "longtext",
                nullable: true
            );

            migrationBuilder
                .CreateTable(
                    name: "Account",
                    columns: table => new
                    {
                        Id = table
                            .Column<uint>(type: "int unsigned", nullable: false)
                            .Annotation(
                                "MySQL:ValueGenerationStrategy",
                                MySQLValueGenerationStrategy.IdentityColumn
                            ),
                        Username = table.Column<string>(type: "longtext", nullable: false),
                        Salt = table.Column<byte[]>(type: "longblob", nullable: false),
                        Verifier = table.Column<byte[]>(type: "longblob", nullable: false),
                        SessionKey = table.Column<byte[]>(type: "longblob", nullable: true),
                        TotpSecret = table.Column<byte[]>(type: "longblob", nullable: true),
                        Email = table.Column<string>(type: "longtext", nullable: false),
                        RegMail = table.Column<string>(type: "longtext", nullable: false),
                        Joindate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        LastIp = table.Column<string>(type: "longtext", nullable: false),
                        LastAttemptIp = table.Column<string>(type: "longtext", nullable: false),
                        FailedLogins = table.Column<uint>(type: "int unsigned", nullable: false),
                        Locked = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                        LockCountry = table.Column<string>(type: "longtext", nullable: false),
                        LastLogin = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        Online = table.Column<uint>(type: "int unsigned", nullable: false),
                        Expansion = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                        Mutetime = table.Column<long>(type: "bigint", nullable: false),
                        Mutereason = table.Column<string>(type: "longtext", nullable: false),
                        Muteby = table.Column<string>(type: "longtext", nullable: false),
                        Locale = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                        Os = table.Column<string>(type: "longtext", nullable: false),
                        Recruiter = table.Column<uint>(type: "int unsigned", nullable: false),
                        Totaltime = table.Column<uint>(type: "int unsigned", nullable: false)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Account", x => x.Id);
                    }
                )
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "AccountAssociations",
                    columns: table => new
                    {
                        Id = table
                            .Column<ulong>(type: "bigint unsigned", nullable: false)
                            .Annotation(
                                "MySQL:ValueGenerationStrategy",
                                MySQLValueGenerationStrategy.IdentityColumn
                            ),
                        UserId = table.Column<ulong>(type: "bigint unsigned", nullable: true),
                        AccountId = table.Column<uint>(type: "int unsigned", nullable: true),
                        Guid = table.Column<string>(type: "longtext", nullable: true),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        CreatedBy = table.Column<ulong>(type: "bigint unsigned", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        UpdatedBy = table.Column<ulong>(type: "bigint unsigned", nullable: false)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_AccountAssociations", x => x.Id);
                        table.ForeignKey(
                            name: "FK_AccountAssociations_Account_AccountId",
                            column: x => x.AccountId,
                            principalTable: "Account",
                            principalColumn: "Id"
                        );
                        table.ForeignKey(
                            name: "FK_AccountAssociations_Users_UserId",
                            column: x => x.UserId,
                            principalTable: "Users",
                            principalColumn: "Id"
                        );
                    }
                )
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AccountAssociations_AccountId",
                table: "AccountAssociations",
                column: "AccountId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_AccountAssociations_UserId",
                table: "AccountAssociations",
                column: "UserId"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "AccountAssociations");

            migrationBuilder.DropTable(name: "Account");

            migrationBuilder.DropColumn(name: "Guid", table: "Users");

            migrationBuilder.DropColumn(name: "Guid", table: "Roles");
        }
    }
}
