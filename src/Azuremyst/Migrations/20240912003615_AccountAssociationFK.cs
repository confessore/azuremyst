using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Azuremyst.Migrations
{
    /// <inheritdoc />
    public partial class AccountAssociationFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountAssociations_Account_AccountId",
                table: "AccountAssociations"
            );

            migrationBuilder.DropTable(name: "Account");

            migrationBuilder.DropIndex(
                name: "IX_AccountAssociations_AccountId",
                table: "AccountAssociations"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                        Email = table.Column<string>(type: "longtext", nullable: false),
                        Expansion = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                        FailedLogins = table.Column<uint>(type: "int unsigned", nullable: false),
                        Joindate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                        LastAttemptIp = table.Column<string>(type: "longtext", nullable: false),
                        LastIp = table.Column<string>(type: "longtext", nullable: false),
                        LastLogin = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        Locale = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                        LockCountry = table.Column<string>(type: "longtext", nullable: false),
                        Locked = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                        Muteby = table.Column<string>(type: "longtext", nullable: false),
                        Mutereason = table.Column<string>(type: "longtext", nullable: false),
                        Mutetime = table.Column<long>(type: "bigint", nullable: false),
                        Online = table.Column<uint>(type: "int unsigned", nullable: false),
                        Os = table.Column<string>(type: "longtext", nullable: false),
                        Recruiter = table.Column<uint>(type: "int unsigned", nullable: false),
                        RegMail = table.Column<string>(type: "longtext", nullable: false),
                        Salt = table.Column<byte[]>(type: "longblob", nullable: false),
                        SessionKey = table.Column<byte[]>(type: "longblob", nullable: true),
                        Totaltime = table.Column<uint>(type: "int unsigned", nullable: false),
                        TotpSecret = table.Column<byte[]>(type: "longblob", nullable: true),
                        Username = table.Column<string>(type: "longtext", nullable: false),
                        Verifier = table.Column<byte[]>(type: "longblob", nullable: false)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Account", x => x.Id);
                    }
                )
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AccountAssociations_AccountId",
                table: "AccountAssociations",
                column: "AccountId"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_AccountAssociations_Account_AccountId",
                table: "AccountAssociations",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id"
            );
        }
    }
}
