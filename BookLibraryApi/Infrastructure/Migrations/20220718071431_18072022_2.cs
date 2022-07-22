using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class _18072022_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(8417), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(8421), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(8423), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(8425), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9093), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9096), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9098), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9056), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9059), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9062), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9064), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9117), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9119), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9121), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9143), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9145), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9147), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9148), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9409), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9412), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9413), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9727), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9730), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9731), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "UserBaskets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Currency", "UserId" },
                values: new object[] { "EUR", 3 });

            migrationBuilder.UpdateData(
                table: "UserBaskets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Currency", "UserId" },
                values: new object[] { "USD", 2 });

            migrationBuilder.UpdateData(
                table: "UserBaskets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Currency", "UserId" },
                values: new object[] { "GBP", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9752), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9755), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9757), new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9757) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 1,
                columns: new[] { "Currency", "UserId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "UserBaskets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Currency", "UserId" },
                values: new object[] { null, 3 });

            migrationBuilder.UpdateData(
                table: "UserBaskets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Currency", "UserId" },
                values: new object[] { null, 2 });

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
    }
}
