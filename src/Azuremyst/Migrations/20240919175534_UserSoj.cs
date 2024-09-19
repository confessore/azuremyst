using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Azuremyst.Migrations
{
    /// <inheritdoc />
    public partial class UserSoj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Soj",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Soj",
                table: "Users");
        }
    }
}
