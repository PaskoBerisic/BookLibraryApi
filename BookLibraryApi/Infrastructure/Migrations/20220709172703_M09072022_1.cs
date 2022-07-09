using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class M09072022_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6263), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6268), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6273), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6275), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6716), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6718), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6720), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6692), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6695), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6697), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6699), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6739), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6741), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6742), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6754), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6756), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6757), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6758), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6992), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6994), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6995), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7170), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7172), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7173), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7191), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7194), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7196), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7196) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2521), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2525), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2527), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2530), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2977), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2980), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2982), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2951), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2954), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2956), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2958), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2998), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3001), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3002), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3017), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3019), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3021), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3022), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3210), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3212), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3214), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3457), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3459), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3461), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3477), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3481), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3482), new DateTime(2022, 7, 9, 17, 25, 7, 47, DateTimeKind.Utc).AddTicks(3483) });
        }
    }
}
