using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Retreat_Management_System.web.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameRetreatdetailsToRetreat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_RetreatDetails_RetreatDetailsID",
                table: "Booking");

            migrationBuilder.DropTable(
                name: "RetreatDetails");

            migrationBuilder.DropIndex(
                name: "IX_Booking_RetreatDetailsID",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "RetreatDetailsID",
                table: "Booking");

            migrationBuilder.CreateTable(
                name: "Retreat",
                columns: table => new
                {
                    RetreatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RetreatName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retreat", x => x.RetreatID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RetreatID",
                table: "Booking",
                column: "RetreatID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Retreat_RetreatID",
                table: "Booking",
                column: "RetreatID",
                principalTable: "Retreat",
                principalColumn: "RetreatID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Retreat_RetreatID",
                table: "Booking");

            migrationBuilder.DropTable(
                name: "Retreat");

            migrationBuilder.DropIndex(
                name: "IX_Booking_RetreatID",
                table: "Booking");

            migrationBuilder.AddColumn<int>(
                name: "RetreatDetailsID",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RetreatDetails",
                columns: table => new
                {
                    RetreatDetailsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RetreatName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetreatDetails", x => x.RetreatDetailsID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RetreatDetailsID",
                table: "Booking",
                column: "RetreatDetailsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_RetreatDetails_RetreatDetailsID",
                table: "Booking",
                column: "RetreatDetailsID",
                principalTable: "RetreatDetails",
                principalColumn: "RetreatDetailsID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
