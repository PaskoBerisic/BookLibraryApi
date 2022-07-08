using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Initial01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1814), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1818), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1820), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1822), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2329), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2332), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2334), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2298), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2301), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2306), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2308), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2350), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2352), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2354), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2370), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2372), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2374), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2376), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2586), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2589), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2591), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2622), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2624), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2626), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2642), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2647), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2649), new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2649) });
        }
    }
}
