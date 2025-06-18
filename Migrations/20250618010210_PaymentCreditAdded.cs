using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayStation.Migrations
{
    /// <inheritdoc />
    public partial class PaymentCreditAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AmountPaid",
                table: "Session",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                table: "Session",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsCredit",
                table: "Session",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "RemainingBalance",
                table: "Session",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountPaid",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "ClientName",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "IsCredit",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "RemainingBalance",
                table: "Session");
        }
    }
}
