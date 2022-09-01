using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class _06082022_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserBaskets_UserBasketId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "UserBasketId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(4669), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(4673), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(4675), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(4676), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5562), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5564), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5574), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5520), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5524), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5526), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5528), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5603), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5605), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5607), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5634), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5636), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5638), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5639), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5961), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5963), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5964), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(6466), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(6468), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(6470), new DateTime(2022, 8, 6, 6, 35, 26, 92, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "PasswordCrypted", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 323, DateTimeKind.Utc).AddTicks(8447), "$2a$11$dg1qANaDBDinrMDVG.17ferYZX2kb0Zg7Z5lEjF0SbkLfJ6QNrI6i", new DateTime(2022, 8, 6, 6, 35, 26, 323, DateTimeKind.Utc).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "PasswordCrypted", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 561, DateTimeKind.Utc).AddTicks(6145), "$2a$11$shQRy4DsTY.wN8tH7thkdebaYQnieJE5aDgUqzd1nuwHmHLzn980W", new DateTime(2022, 8, 6, 6, 35, 26, 561, DateTimeKind.Utc).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "PasswordCrypted", "Updated" },
                values: new object[] { new DateTime(2022, 8, 6, 6, 35, 26, 820, DateTimeKind.Utc).AddTicks(1511), "$2a$11$VkX/JrpJL9cOoAsMu0Pp9ePs5Ie2h.d7qxYmOAf2i2Qx6M1U7rfDC", new DateTime(2022, 8, 6, 6, 35, 26, 820, DateTimeKind.Utc).AddTicks(1512) });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserBaskets_UserBasketId",
                table: "Users",
                column: "UserBasketId",
                principalTable: "UserBaskets",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserBaskets_UserBasketId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "UserBasketId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(2524), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(2527), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(2529), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(2530), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3071), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3074), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3086), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3041), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3045), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3047), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3049), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3105), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3107), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3108), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3124), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3127), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3128), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3130), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3478), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3480), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3481), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3795), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3797), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3798), new DateTime(2022, 7, 30, 12, 37, 55, 707, DateTimeKind.Utc).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "PasswordCrypted", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 910, DateTimeKind.Utc).AddTicks(1686), "$2a$11$eGH0RxFdFfLkGxuUNKMk3u5yX4Z.plQGzWf/JD2FlYQd/wCv44uYK", new DateTime(2022, 7, 30, 12, 37, 55, 910, DateTimeKind.Utc).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "PasswordCrypted", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 56, 139, DateTimeKind.Utc).AddTicks(8312), "$2a$11$dGKutyPsAdOGlgABfp823euFXKGio/MISLIxnBAKEvFsN2bTH483K", new DateTime(2022, 7, 30, 12, 37, 56, 139, DateTimeKind.Utc).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "PasswordCrypted", "Updated" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 56, 365, DateTimeKind.Utc).AddTicks(5820), "$2a$11$Ez89BLMJOuZFdG7dDQ0xsemhZ2wDjNn9p7TUpRqF24ttjbO5Gtzzq", new DateTime(2022, 7, 30, 12, 37, 56, 365, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserBaskets_UserBasketId",
                table: "Users",
                column: "UserBasketId",
                principalTable: "UserBaskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
