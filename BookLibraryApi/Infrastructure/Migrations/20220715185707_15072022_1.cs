using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class _15072022_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitsRented",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "Created", "UnitsRented", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4742), 10, new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "UnitsRented", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4745), 15, new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "UnitsRented", "Updated" },
                values: new object[] { new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4747), 2, new DateTime(2022, 7, 15, 18, 57, 6, 883, DateTimeKind.Utc).AddTicks(4747) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitsRented",
                table: "Books");

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
    }
}
