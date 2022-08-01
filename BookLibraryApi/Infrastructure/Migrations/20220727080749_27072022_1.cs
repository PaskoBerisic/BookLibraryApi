using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class _27072022_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordCrypted",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(6835), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(6838), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(6839), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(6841), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7490), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7492), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7498), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7465), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7468), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7470), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7472), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7514), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7516), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7517), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7532), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7534), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7535), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7536), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7964), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7966), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7967), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(8216), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(8217), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(8218), new DateTime(2022, 7, 27, 8, 7, 47, 716, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Email", "Password", "PasswordCrypted", "Updated", "Username" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 932, DateTimeKind.Utc).AddTicks(407), "username1@gmail.com", null, "$2a$11$PWzIDt62pFbFNr7kJpMXjOrvQuA5eK8IZr64BxoHhR6fXRYyljaBG", new DateTime(2022, 7, 27, 8, 7, 47, 932, DateTimeKind.Utc).AddTicks(409), "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Email", "Password", "PasswordCrypted", "Role", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 48, 135, DateTimeKind.Utc).AddTicks(1082), "test@gmail.com", null, "$2a$11$ANj29aCVJq5yBRxkYzSf9.uPaElAzER6JJqUjqtPTww0gLZUEKI5K", 2, new DateTime(2022, 7, 27, 8, 7, 48, 135, DateTimeKind.Utc).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Email", "Password", "PasswordCrypted", "Role", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 48, 354, DateTimeKind.Utc).AddTicks(941), "test2@gmail.com", null, "$2a$11$ss/6AV/64hcNcTdVxBIGU.CDh7Rv0Ski2UaucVUtWOIUyndJ7rGP.", 2, new DateTime(2022, 7, 27, 8, 7, 48, 354, DateTimeKind.Utc).AddTicks(945) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordCrypted",
                table: "Users");

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
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Password", "Updated", "Username" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9752), "123456", new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9753), "User1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Password", "Role", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9755), "123456", 0, new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Password", "Role", "Updated" },
                values: new object[] { new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9757), "123456", 0, new DateTime(2022, 7, 18, 7, 14, 30, 724, DateTimeKind.Utc).AddTicks(9757) });
        }
    }
}
