using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class M09072022_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(2486), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(2490), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(2492), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(2494), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(2494) });

            migrationBuilder.InsertData(
                table: "BookOrder",
                columns: new[] { "BooksId", "OrdersId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 19, 4 }
                });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3028), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3031), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3033), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(2997), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3001), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3003), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3005), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3052), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3054), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3056), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3074), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3077), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3079), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3080), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3292), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3295), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3297), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3645), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3647), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3649), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3666), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3669), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3672), new DateTime(2022, 7, 9, 20, 49, 42, 655, DateTimeKind.Utc).AddTicks(3672) });
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
                keyValues: new object[] { 19, 4 });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3826), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3833), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3837), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3840), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4866), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4873), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4877), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4803), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4810), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4814), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4817), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4912), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4916), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4920), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4962), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4967), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4970), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4973), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5539), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5543), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5546), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5952), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5956), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5960), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5993), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5999), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(6003), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(6004) });
        }
    }
}
