using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class _18072022_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6165), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6168), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6170), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6172), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6875), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6880), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6882), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6785), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6796), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6801), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6806), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6905), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6908), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6910), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6930), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6932), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6933), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6935), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7386), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7389), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7390), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7694), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7697), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7698), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "UserBaskets",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7722), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7726), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7727), new DateTime(2022, 7, 18, 6, 58, 57, 942, DateTimeKind.Utc).AddTicks(7727) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "UserBaskets",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: 1);

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
    }
}
