using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class _10072022_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookOrder",
                keyColumns: new[] { "BooksId", "OrdersId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BookOrder",
                keyColumns: new[] { "BooksId", "OrdersId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "BookOrder",
                keyColumns: new[] { "BooksId", "OrdersId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "BookOrder",
                keyColumns: new[] { "BooksId", "OrdersId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(7940), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(7942), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(7943), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(7944), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(7945) });

            migrationBuilder.InsertData(
                table: "BookOrder",
                columns: new[] { "BooksId", "OrdersId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 2, 3 },
                    { 3, 2 },
                    { 4, 1 }
                });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8276), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8278), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8279), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8257), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8259), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8260), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8261), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8292), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8293), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8294), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8347), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8348), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8349), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8350), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8505), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8507), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8508), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8663), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8665), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8666), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8680), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8681), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8683), new DateTime(2022, 7, 10, 9, 36, 29, 666, DateTimeKind.Utc).AddTicks(8683) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookOrder",
                keyColumns: new[] { "BooksId", "OrdersId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "BookOrder",
                keyColumns: new[] { "BooksId", "OrdersId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "BookOrder",
                keyColumns: new[] { "BooksId", "OrdersId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "BookOrder",
                keyColumns: new[] { "BooksId", "OrdersId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(5858), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(5861), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(5862), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(5863), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(5864) });

            migrationBuilder.InsertData(
                table: "BookOrder",
                columns: new[] { "BooksId", "OrdersId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 }
                });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6194), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6199), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6201), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6176), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6178), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6179), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6181), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6209), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6211), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6212), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6223), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6225), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6226), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6227), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6367), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6368), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6369), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6558), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6560), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6561), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6573), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6575), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6576), new DateTime(2022, 7, 10, 9, 35, 18, 551, DateTimeKind.Utc).AddTicks(6576) });
        }
    }
}
