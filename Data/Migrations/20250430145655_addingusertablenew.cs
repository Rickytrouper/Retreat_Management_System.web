﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Retreat_Management_System.web.Data.Migrations
{
    /// <inheritdoc />
    public partial class addingusertablenew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "User",
                newName: "Password");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "PasswordHash");
        }
    }
}
