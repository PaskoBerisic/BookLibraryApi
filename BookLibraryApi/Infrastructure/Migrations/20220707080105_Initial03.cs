using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Initial03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: 3);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: 1);

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
        }
    }
}
