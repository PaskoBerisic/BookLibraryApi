using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class _12072022_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Users",
                newName: "Address");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(4664), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(4748), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(4752), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(4755), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5758), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5763), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5766), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5542), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5547), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5553), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5557), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5806), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5809), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5812), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5844), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5847), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5850), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5856), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(6669), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(6676), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(6678), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(7330), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(7333), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(7335), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(7370), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(7374), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(7378), new DateTime(2022, 7, 12, 18, 50, 51, 326, DateTimeKind.Utc).AddTicks(7378) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Users",
                newName: "Adress");

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
    }
}
