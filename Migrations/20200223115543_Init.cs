using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SSSApp.API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarCategory",
                columns: table => new
                {
                    CarCategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCategory", x => x.CarCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Condition",
                columns: table => new
                {
                    ConditionsId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condition", x => x.ConditionsId);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    DriverId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DriverNick = table.Column<string>(nullable: true),
                    FavouriteNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.DriverId);
                });

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

            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    TrackId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TrackName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.TrackId);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarName = table.Column<string>(nullable: true),
                    CarCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Car_CarCategory_CarCategoryId",
                        column: x => x.CarCategoryId,
                        principalTable: "CarCategory",
                        principalColumn: "CarCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rally",
                columns: table => new
                {
                    RallyId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RallyName = table.Column<string>(nullable: true),
                    EventDate = table.Column<DateTime>(nullable: false),
                    CarCategoryId = table.Column<int>(nullable: true),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rally", x => x.RallyId);
                    table.ForeignKey(
                        name: "FK_Rally_CarCategory_CarCategoryId",
                        column: x => x.CarCategoryId,
                        principalTable: "CarCategory",
                        principalColumn: "CarCategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rally_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RallyEntry",
                columns: table => new
                {
                    RallyEntryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartingNumber = table.Column<int>(nullable: false),
                    CarId = table.Column<int>(nullable: false),
                    DriverId = table.Column<int>(nullable: false),
                    RallyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RallyEntry", x => x.RallyEntryId);
                    table.ForeignKey(
                        name: "FK_RallyEntry_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RallyEntry_Driver_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Driver",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RallyEntry_Rally_RallyId",
                        column: x => x.RallyId,
                        principalTable: "Rally",
                        principalColumn: "RallyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stage",
                columns: table => new
                {
                    StageId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RallyId = table.Column<int>(nullable: false),
                    TrackId = table.Column<int>(nullable: false),
                    ConditionsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage", x => x.StageId);
                    table.ForeignKey(
                        name: "FK_Stage_Condition_ConditionsId",
                        column: x => x.ConditionsId,
                        principalTable: "Condition",
                        principalColumn: "ConditionsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stage_Rally_RallyId",
                        column: x => x.RallyId,
                        principalTable: "Rally",
                        principalColumn: "RallyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stage_Track_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Track",
                        principalColumn: "TrackId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    ResultId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Time = table.Column<TimeSpan>(nullable: false),
                    DNF = table.Column<bool>(nullable: false),
                    RallyEntryId = table.Column<int>(nullable: false),
                    StageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x.ResultId);
                    table.ForeignKey(
                        name: "FK_Result_RallyEntry_RallyEntryId",
                        column: x => x.RallyEntryId,
                        principalTable: "RallyEntry",
                        principalColumn: "RallyEntryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Result_Stage_StageId",
                        column: x => x.StageId,
                        principalTable: "Stage",
                        principalColumn: "StageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarCategoryId",
                table: "Car",
                column: "CarCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Rally_CarCategoryId",
                table: "Rally",
                column: "CarCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Rally_OrderId",
                table: "Rally",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_RallyEntry_CarId",
                table: "RallyEntry",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_RallyEntry_DriverId",
                table: "RallyEntry",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_RallyEntry_RallyId",
                table: "RallyEntry",
                column: "RallyId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_RallyEntryId",
                table: "Result",
                column: "RallyEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_StageId",
                table: "Result",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_ConditionsId",
                table: "Stage",
                column: "ConditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_RallyId",
                table: "Stage",
                column: "RallyId");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_TrackId",
                table: "Stage",
                column: "TrackId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropTable(
                name: "RallyEntry");

            migrationBuilder.DropTable(
                name: "Stage");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "Condition");

            migrationBuilder.DropTable(
                name: "Rally");

            migrationBuilder.DropTable(
                name: "Track");

            migrationBuilder.DropTable(
                name: "CarCategory");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
