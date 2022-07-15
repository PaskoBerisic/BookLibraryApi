using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class _15072022_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(7707), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(7714), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(7717), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(7719), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9780), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9784), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9787), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9718), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9725), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9732), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9735), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9826), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9832), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9836), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9885), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9888), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9890), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9892), new DateTime(2022, 7, 15, 18, 59, 34, 103, DateTimeKind.Utc).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(579), new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(582), new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(584), new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(1076), new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(1077) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(1079), new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(1081), new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(1119), new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(1123), new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(1126), new DateTime(2022, 7, 15, 18, 59, 34, 104, DateTimeKind.Utc).AddTicks(1127) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4251), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4254), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4256), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4258), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4768), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4770), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4772), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4742), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4745), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4747), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4749), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4785), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4788), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4790), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4807), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4809), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4810), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4811), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4999), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5001), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5002), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5249), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5251), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5253), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5269), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5272), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5273), new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(5274) });
        }
    }
}
