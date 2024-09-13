using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Azuremyst.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase().Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "DataProtectionKeys",
                    columns: table => new
                    {
                        Id = table
                            .Column<int>(type: "int", nullable: false)
                            .Annotation(
                                "MySQL:ValueGenerationStrategy",
                                MySQLValueGenerationStrategy.IdentityColumn
                            ),
                        FriendlyName = table.Column<string>(type: "longtext", nullable: true),
                        Xml = table.Column<string>(type: "longtext", nullable: true)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_DataProtectionKeys", x => x.Id);
                    }
                )
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "Roles",
                    columns: table => new
                    {
                        Id = table
                            .Column<ulong>(type: "bigint unsigned", nullable: false)
                            .Annotation(
                                "MySQL:ValueGenerationStrategy",
                                MySQLValueGenerationStrategy.IdentityColumn
                            ),
                        RoleType = table.Column<int>(type: "int", nullable: false),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        CreatedBy = table.Column<ulong>(type: "bigint unsigned", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        UpdatedBy = table.Column<ulong>(type: "bigint unsigned", nullable: false)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Roles", x => x.Id);
                    }
                )
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder
                .CreateTable(
                    name: "Users",
                    columns: table => new
                    {
                        Id = table
                            .Column<ulong>(type: "bigint unsigned", nullable: false)
                            .Annotation(
                                "MySQL:ValueGenerationStrategy",
                                MySQLValueGenerationStrategy.IdentityColumn
                            ),
                        CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        CreatedBy = table.Column<ulong>(type: "bigint unsigned", nullable: false),
                        UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                        UpdatedBy = table.Column<ulong>(type: "bigint unsigned", nullable: false)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Users", x => x.Id);
                    }
                )
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "DataProtectionKeys");

            migrationBuilder.DropTable(name: "Roles");

            migrationBuilder.DropTable(name: "Users");
        }
    }
}
