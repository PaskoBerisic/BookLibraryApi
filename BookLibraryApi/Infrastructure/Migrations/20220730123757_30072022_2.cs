using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class _30072022_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_UserBaskets_UserBasketId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBaskets_Users_UserId",
                table: "UserBaskets");

            migrationBuilder.DropIndex(
                name: "IX_UserBaskets_UserId",
                table: "UserBaskets");

            migrationBuilder.DropIndex(
                name: "IX_Books_UserBasketId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserBaskets");

            migrationBuilder.DropColumn(
                name: "UserBasketId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "UserBasketId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BookUserBasket",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    UserBasketsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookUserBasket", x => new { x.BooksId, x.UserBasketsId });
                    table.ForeignKey(
                        name: "FK_BookUserBasket_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookUserBasket_UserBaskets_UserBasketsId",
                        column: x => x.UserBasketsId,
                        principalTable: "UserBaskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "BookUserBasket",
                columns: new[] { "BooksId", "UserBasketsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 3 }
                });

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
                columns: new[] { "Created", "PasswordCrypted", "Updated", "UserBasketId" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 55, 910, DateTimeKind.Utc).AddTicks(1686), "$2a$11$eGH0RxFdFfLkGxuUNKMk3u5yX4Z.plQGzWf/JD2FlYQd/wCv44uYK", new DateTime(2022, 7, 30, 12, 37, 55, 910, DateTimeKind.Utc).AddTicks(1687), 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "PasswordCrypted", "Updated", "UserBasketId" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 56, 139, DateTimeKind.Utc).AddTicks(8312), "$2a$11$dGKutyPsAdOGlgABfp823euFXKGio/MISLIxnBAKEvFsN2bTH483K", new DateTime(2022, 7, 30, 12, 37, 56, 139, DateTimeKind.Utc).AddTicks(8313), 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "PasswordCrypted", "Updated", "UserBasketId" },
                values: new object[] { new DateTime(2022, 7, 30, 12, 37, 56, 365, DateTimeKind.Utc).AddTicks(5820), "$2a$11$Ez89BLMJOuZFdG7dDQ0xsemhZ2wDjNn9p7TUpRqF24ttjbO5Gtzzq", new DateTime(2022, 7, 30, 12, 37, 56, 365, DateTimeKind.Utc).AddTicks(5822), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserBasketId",
                table: "Users",
                column: "UserBasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BookUserBasket_UserBasketsId",
                table: "BookUserBasket",
                column: "UserBasketsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserBaskets_UserBasketId",
                table: "Users",
                column: "UserBasketId",
                principalTable: "UserBaskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserBaskets_UserBasketId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "BookUserBasket");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserBasketId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserBasketId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserBaskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserBasketId",
                table: "Books",
                type: "int",
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
                table: "UserBaskets",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "UserBaskets",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "UserBaskets",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "PasswordCrypted", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 47, 932, DateTimeKind.Utc).AddTicks(407), "$2a$11$PWzIDt62pFbFNr7kJpMXjOrvQuA5eK8IZr64BxoHhR6fXRYyljaBG", new DateTime(2022, 7, 27, 8, 7, 47, 932, DateTimeKind.Utc).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "PasswordCrypted", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 48, 135, DateTimeKind.Utc).AddTicks(1082), "$2a$11$ANj29aCVJq5yBRxkYzSf9.uPaElAzER6JJqUjqtPTww0gLZUEKI5K", new DateTime(2022, 7, 27, 8, 7, 48, 135, DateTimeKind.Utc).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "PasswordCrypted", "Updated" },
                values: new object[] { new DateTime(2022, 7, 27, 8, 7, 48, 354, DateTimeKind.Utc).AddTicks(941), "$2a$11$ss/6AV/64hcNcTdVxBIGU.CDh7Rv0Ski2UaucVUtWOIUyndJ7rGP.", new DateTime(2022, 7, 27, 8, 7, 48, 354, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.CreateIndex(
                name: "IX_UserBaskets_UserId",
                table: "UserBaskets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserBasketId",
                table: "Books",
                column: "UserBasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_UserBaskets_UserBasketId",
                table: "Books",
                column: "UserBasketId",
                principalTable: "UserBaskets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBaskets_Users_UserId",
                table: "UserBaskets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
