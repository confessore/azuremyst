using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace azuremyst.Migrations
{
    public partial class _115613_19072022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Coins",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CreatedAt",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CreatedAt",
                table: "Tokens",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CreatedAt",
                table: "Roles",
                type: "bigint",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coins",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Tokens");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Roles");
        }
    }
}
