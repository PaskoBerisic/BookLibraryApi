using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Initial02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Orders_OrderId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_OrderId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Books");

            migrationBuilder.CreateTable(
                name: "BookOrder",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    OrdersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookOrder", x => new { x.BooksId, x.OrdersId });
                    table.ForeignKey(
                        name: "FK_BookOrder_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookOrder_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7389), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7393), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7395), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7397), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7398) });

            migrationBuilder.InsertData(
                table: "BookOrder",
                columns: new[] { "BooksId", "OrdersId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 2 }
                });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7912), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7915), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7918), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7875), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7879), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7881), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7883), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7943), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7946), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7947), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7964), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7967), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7968), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7970), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8255), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8259), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8261), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8497), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8500), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8502), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8521), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8524), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8526), new DateTime(2022, 7, 5, 19, 29, 40, 678, DateTimeKind.Utc).AddTicks(8527) });

            migrationBuilder.CreateIndex(
                name: "IX_BookOrder_OrdersId",
                table: "BookOrder",
                column: "OrdersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookOrder");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(3645), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(3649), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(3651), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(3652), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4062), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4112), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4114), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4035), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4038), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4041), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4042), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4132), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4134), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4136), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4153), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4155), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4157), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4158), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4360), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4362), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4364), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4395), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4397), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4399), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4413), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4416), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4418), new DateTime(2022, 7, 5, 19, 6, 25, 224, DateTimeKind.Utc).AddTicks(4418) });

            migrationBuilder.CreateIndex(
                name: "IX_Books_OrderId",
                table: "Books",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Orders_OrderId",
                table: "Books",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
