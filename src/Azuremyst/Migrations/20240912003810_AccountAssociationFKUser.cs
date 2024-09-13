using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Azuremyst.Migrations
{
    /// <inheritdoc />
    public partial class AccountAssociationFKUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountAssociations_Users_UserId",
                table: "AccountAssociations"
            );

            migrationBuilder.DropIndex(
                name: "IX_AccountAssociations_UserId",
                table: "AccountAssociations"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AccountAssociations_UserId",
                table: "AccountAssociations",
                column: "UserId"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_AccountAssociations_Users_UserId",
                table: "AccountAssociations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id"
            );
        }
    }
}
