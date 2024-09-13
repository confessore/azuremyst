﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Azuremyst.Migrations
{
    /// <inheritdoc />
    public partial class NameEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "longtext",
                nullable: true
            );

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "longtext",
                nullable: true
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Email", table: "Users");

            migrationBuilder.DropColumn(name: "Name", table: "Users");
        }
    }
}
