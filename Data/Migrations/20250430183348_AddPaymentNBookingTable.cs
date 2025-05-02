using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Retreat_Management_System.web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymentNBookingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Retreat_RetreatID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_User_UserID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Booking_BookingID",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_BookingID",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Booking_RetreatID",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_UserID",
                table: "Booking");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "User",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "User",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "ContactInfo",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactInfo",
                table: "Retreat",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Retreat",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Retreat",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Retreat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Retreat",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OrganizerID",
                table: "Retreat",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookingID",
                table: "Payment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "TransactionID",
                table: "Payment",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Booking",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RetreatID",
                table: "Booking",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CVV",
                table: "Booking",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "Booking",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Booking",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                table: "Booking",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "Booking",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Booking",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactInfo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ContactInfo",
                table: "Retreat");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Retreat");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Retreat");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Retreat");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Retreat");

            migrationBuilder.DropColumn(
                name: "OrganizerID",
                table: "Retreat");

            migrationBuilder.DropColumn(
                name: "TransactionID",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "CVV",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Booking");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "BookingID",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RetreatID",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_BookingID",
                table: "Payment",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RetreatID",
                table: "Booking",
                column: "RetreatID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_UserID",
                table: "Booking",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Retreat_RetreatID",
                table: "Booking",
                column: "RetreatID",
                principalTable: "Retreat",
                principalColumn: "RetreatID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_User_UserID",
                table: "Booking",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Booking_BookingID",
                table: "Payment",
                column: "BookingID",
                principalTable: "Booking",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
