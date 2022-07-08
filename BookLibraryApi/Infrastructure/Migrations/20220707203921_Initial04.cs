using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Initial04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(538), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(542), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(544), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(545), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1032), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1036), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1038), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1006), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1009), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1012), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1013), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1052), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1054), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1056), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1069), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1071), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1073), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1074), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1266), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1268), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1270), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1558), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1560), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1562), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1580), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1583), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1585), new DateTime(2022, 7, 7, 20, 39, 20, 213, DateTimeKind.Utc).AddTicks(1585) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7092), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7101), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7103), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7105), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7862), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7866), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7868), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7755), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7759), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7762), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7765), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7896), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7898), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7900), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7930), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7933), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7935), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7938), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(8254), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(8257), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(8259), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(9476), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(9479), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(9481), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(9586), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(9590), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(9593), new DateTime(2022, 7, 7, 8, 1, 3, 528, DateTimeKind.Utc).AddTicks(9593) });
        }
    }
}
