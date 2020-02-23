using Microsoft.EntityFrameworkCore.Migrations;

namespace SSSApp.API.Migrations
{
    public partial class Addedorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Rally",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rally_OrderId",
                table: "Rally",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rally_Order_OrderId",
                table: "Rally",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rally_Order_OrderId",
                table: "Rally");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Rally_OrderId",
                table: "Rally");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Rally");
        }
    }
}
