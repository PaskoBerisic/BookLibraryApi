using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class _02092022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    VAT = table.Column<int>(type: "int", precision: 4, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserBaskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalRentalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TotalRentalPriceWithVAT = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBaskets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Bibliography = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    YearOfPublish = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    RentalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ListPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UnitNumber = table.Column<int>(type: "int", nullable: false),
                    UnitsRented = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PasswordCrypted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    UserBasketId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserBaskets_UserBasketId",
                        column: x => x.UserBasketId,
                        principalTable: "UserBaskets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookAuthor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookGenre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookGenre_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenre_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookUserBasket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserBasketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookUserBasket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookUserBasket_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookUserBasket_UserBaskets_UserBasketId",
                        column: x => x.UserBasketId,
                        principalTable: "UserBaskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    TotalRentalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TotalRentalPriceWithVAT = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookOrder_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookOrder_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Created", "CreatedBy", "Name", "ShortName", "Updated", "UpdatedBy", "VAT" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4381), 1, "England", "ENG", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4381), 1, 25 },
                    { 2, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4382), 1, "France", "FRA", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4383), 1, 20 },
                    { 3, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4384), 1, "Germany", "GER", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4384), 1, 10 }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "Name", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4404), 1, "Description about the genre 1 ", "Genre 1", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4405), 1 },
                    { 2, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4406), 1, "Description about the genre 2", "Genre 2", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4406), 1 },
                    { 3, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4407), 1, "Description about the genre 3", "Genre 3", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4407), 1 },
                    { 4, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4408), 1, "Description about the genre 4", "Genre 4", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4408), 1 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Created", "CreatedBy", "Name", "ShortName", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4426), 1, "English", "Eng", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4427), 1 },
                    { 2, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4428), 1, "France", "Fra", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4428), 1 },
                    { 3, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4429), 1, "Italian", "Ita", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4429), 1 }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Created", "CreatedBy", "Name", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4519), 1, "Publisher 1", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4520), 1 },
                    { 2, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4521), 1, "Publisher 2", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4521), 1 },
                    { 3, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4522), 1, "Publisher 3", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4522), 1 }
                });

            migrationBuilder.InsertData(
                table: "UserBaskets",
                columns: new[] { "Id", "Currency", "TotalRentalPrice", "TotalRentalPriceWithVAT" },
                values: new object[,]
                {
                    { 1, "EUR", 1.20m, 1.50m },
                    { 2, "USD", 1.0m, 1.25m },
                    { 3, "GBP", 1.60m, 2.0m }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bibliography", "CountryId", "Created", "CreatedBy", "DateOfBirth", "FirstName", "LastName", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Bibliography 1", 1, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4202), 1, new DateTime(1950, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name", "Surname", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4205), 1 },
                    { 2, "Bibliography 2", 3, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4207), 1, new DateTime(1800, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name 2", "Surname 2", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4207), 1 },
                    { 3, "Bibliography 3", 1, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4208), 1, new DateTime(2000, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name 3", "Surname 3", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4209), 1 },
                    { 4, "Bibliography 4", 2, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4210), 1, new DateTime(1975, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name 4", "Surname 4", new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4210), 1 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "LanguageId", "ListPrice", "PublisherId", "RentalPrice", "Title", "UnitNumber", "UnitsRented", "Updated", "UpdatedBy", "YearOfPublish" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4354), 1, "Description about the book 1", 3, 0.70m, 1, 1.20m, "Book 1", 3, 10, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4355), 1, 1999 },
                    { 2, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4357), 1, "Description about the book 2", 2, 0.90m, 1, 1.50m, "Book 2", 3, 15, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4357), 1, 1899 },
                    { 3, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4358), 1, "Description about the book 3", 1, 1.70m, 2, 2.20m, "Book 3", 3, 2, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4358), 1, 2005 },
                    { 4, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4360), 1, "Description about the book 4", 2, 1.30m, 3, 1.90m, "Book 4", 5, 0, new DateTime(2022, 9, 2, 9, 42, 14, 25, DateTimeKind.Utc).AddTicks(4360), 1, 1500 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Created", "CreatedBy", "DateOfBirth", "Email", "FirstName", "IsActive", "LastName", "Password", "PasswordCrypted", "Role", "Updated", "UpdatedBy", "UserBasketId", "Username" },
                values: new object[,]
                {
                    { 1, "Address 1", new DateTime(2022, 9, 2, 9, 42, 14, 194, DateTimeKind.Utc).AddTicks(5834), 1, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@booklibrary.com", "Name 1", true, "Surname 1", null, "$2a$11$0aUnTe3ZpwlzuqWNcHkHZOcW./kaFGJMqisgZnGN6eDlsUZx1iSHK", 0, new DateTime(2022, 9, 2, 9, 42, 14, 194, DateTimeKind.Utc).AddTicks(5835), 1, 1, "Admin" },
                    { 2, "Address 2", new DateTime(2022, 9, 2, 9, 42, 14, 385, DateTimeKind.Utc).AddTicks(8869), 1, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@booklibrary.com", "Name 2", true, "Surname 2", null, "$2a$11$yg2DeEAU1xWQETs80R0nQ.6pbx7Z9rvYtoxQeZaEQPSMK9maKMQKC", 2, new DateTime(2022, 9, 2, 9, 42, 14, 385, DateTimeKind.Utc).AddTicks(8871), 1, 2, "User2" },
                    { 3, "Address 3", new DateTime(2022, 9, 2, 9, 42, 14, 554, DateTimeKind.Utc).AddTicks(7892), 1, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@booklibrary.com", "Name 3", true, "Surname 3", null, "$2a$11$Ng6C/aRYJAk/dSChDHYKo.6siIX9kEjbaPHdRZWZmcx7o0QQ0N.qK", 2, new DateTime(2022, 9, 2, 9, 42, 14, 554, DateTimeKind.Utc).AddTicks(7893), 1, 3, "User3" }
                });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "Id", "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 1 },
                    { 4, 2, 2 },
                    { 5, 2, 3 },
                    { 6, 3, 1 },
                    { 7, 1, 4 },
                    { 8, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "BookId", "GenreId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 3, 1, 2 },
                    { 4, 2, 2 },
                    { 5, 1, 3 },
                    { 6, 2, 3 },
                    { 7, 3, 3 },
                    { 8, 2, 4 },
                    { 9, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "BookUserBasket",
                columns: new[] { "Id", "BookId", "UserBasketId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 1, 2 },
                    { 4, 2, 2 },
                    { 5, 3, 2 },
                    { 6, 1, 3 },
                    { 7, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Currency", "Date", "TotalRentalPrice", "TotalRentalPriceWithVAT", "UserId" },
                values: new object[,]
                {
                    { 1, "EUR", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.20m, 1.50m, 1 },
                    { 2, "USD", new DateTime(2019, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.20m, 1.50m, 2 },
                    { 3, "GBP", new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.60m, 2m, 3 },
                    { 4, "HRK", new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.60m, 2m, 2 }
                });

            migrationBuilder.InsertData(
                table: "BookOrder",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 3, 1 },
                    { 3, 1, 2 },
                    { 6, 1, 3 },
                    { 7, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_CountryId",
                table: "Authors",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_AuthorId",
                table: "BookAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_BookId",
                table: "BookAuthor",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_BookId",
                table: "BookGenre",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_GenreId",
                table: "BookGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_BookOrder_BookId",
                table: "BookOrder",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookOrder_OrderId",
                table: "BookOrder",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_LanguageId",
                table: "Books",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_BookUserBasket_BookId",
                table: "BookUserBasket",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookUserBasket_UserBasketId",
                table: "BookUserBasket",
                column: "UserBasketId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserBasketId",
                table: "Users",
                column: "UserBasketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthor");

            migrationBuilder.DropTable(
                name: "BookGenre");

            migrationBuilder.DropTable(
                name: "BookOrder");

            migrationBuilder.DropTable(
                name: "BookUserBasket");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "UserBaskets");
        }
    }
}
