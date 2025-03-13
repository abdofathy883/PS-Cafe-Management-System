using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlayStation.Migrations
{
    /// <inheritdoc />
    public partial class changeSessionAndDeleteOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Order",
                table: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "OrderDetail",
                newName: "SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_OrderID",
                table: "OrderDetail",
                newName: "IX_OrderDetail_SessionId");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Session",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "HourlyRate",
                table: "Device",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.CreateIndex(
                name: "IX_Session_UserId",
                table: "Session",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Order",
                table: "OrderDetail",
                column: "SessionId",
                principalTable: "Session",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Session_User_UserId",
                table: "Session",
                column: "UserId",
                principalTable: "User",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Order",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_User_UserId",
                table: "Session");

            migrationBuilder.DropIndex(
                name: "IX_Session_UserId",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Session");

            migrationBuilder.RenameColumn(
                name: "SessionId",
                table: "OrderDetail",
                newName: "OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_SessionId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_OrderID");

            migrationBuilder.AlterColumn<byte>(
                name: "HourlyRate",
                table: "Device",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionID = table.Column<int>(type: "int", nullable: false),
                    USerID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Order__3214EC2730DE2E8E", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Order_Session",
                        column: x => x.SessionID,
                        principalTable: "Session",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Order_User",
                        column: x => x.USerID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_SessionID",
                table: "Order",
                column: "SessionID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_USerID",
                table: "Order",
                column: "USerID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Order",
                table: "OrderDetail",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "ID");
        }
    }
}
