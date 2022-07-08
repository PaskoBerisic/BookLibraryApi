using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Initial : Migration
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
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
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
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Bibliography = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false)
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
                name: "SystemSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    DefaultCurrency = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemSettings_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    TotalRentalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TotalRentalPriceWithVAT = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true)
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
                name: "UserBaskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TotalRentalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TotalRentalPriceWithVAT = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBaskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBaskets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookRentals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    RentedFromDate = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    RentedToDate = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    ReturnedDate = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookRentals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookRentals_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
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
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    YearOfPublish = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    RentalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ListPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UnitNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", maxLength: 25, nullable: false),
                    BookRentalId = table.Column<int>(type: "int", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    UserBasketId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_BookRentals_BookRentalId",
                        column: x => x.BookRentalId,
                        principalTable: "BookRentals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_UserBaskets_UserBasketId",
                        column: x => x.UserBasketId,
                        principalTable: "UserBaskets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    AuthorsId = table.Column<int>(type: "int", nullable: false),
                    BooksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.AuthorsId, x.BooksId });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookGenre",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    GenresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenre", x => new { x.BooksId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_BookGenre_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenre_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Created", "CreatedBy", "Name", "ShortName", "Updated", "UpdatedBy", "VAT" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2350), 1, "England", "Eng", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2351), 1, 25 },
                    { 2, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2352), 1, "France", "Fra", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2353), 1, 20 },
                    { 3, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2354), 1, "Germany", "GER", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2354), 1, 10 }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsActive", "Name", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2370), 1, "Description about the genre 1 ", true, "Genre 1", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2371), 1 },
                    { 2, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2372), 1, "Description about the genre 2", false, "Genre 2", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2373), 1 },
                    { 3, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2374), 1, "Description about the genre 3", true, "Genre 3", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2375), 1 },
                    { 4, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2376), 1, "Description about the genre 3", true, "Documentary", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2376), 1 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Created", "CreatedBy", "Name", "ShortName", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2586), 1, "English", "Eng", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2587), 1 },
                    { 2, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2589), 1, "France", "Fra", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2589), 1 },
                    { 3, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2591), 1, "German", "Ger", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2591), 1 }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Created", "CreatedBy", "Name", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2622), 1, "Publisher 1", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2623), 1 },
                    { 2, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2624), 1, "Publisher 2", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2625), 1 },
                    { 3, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2626), 1, "Publisher 3", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2626), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Adress", "Created", "CreatedBy", "DateOfBirth", "FirstName", "IsActive", "LastName", "Password", "Role", "Updated", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { 1, "Adresa 1", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2642), 1, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name 1", true, "Surname 1", "123456", 0, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2644), 1, "User1" },
                    { 2, "Adresa 2", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2647), 1, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name 2", true, "Surname 2", "123456", 0, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2647), 1, "User2" },
                    { 3, "Adresa 2", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2649), 1, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name 2", true, "Surname 2", "123456", 0, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2649), 1, "User2" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bibliography", "CountryId", "Created", "CreatedBy", "DateOfBirth", "FirstName", "LastName", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Bibliography 1", 1, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1814), 1, new DateTime(1950, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name", "Surname", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1815), 1 },
                    { 2, "Bibliography 2", 1, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1818), 1, new DateTime(1950, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name 2", "Surname 2", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1818), 1 },
                    { 3, "Bibliography 3", 1, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1820), 1, new DateTime(1950, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name 3", "Surname 3", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1820), 1 },
                    { 10, "Bibliography 8", 2, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1822), 1, new DateTime(1975, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elon", "Musk", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(1822), 1 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookRentalId", "Created", "CreatedBy", "Description", "LanguageId", "ListPrice", "OrderId", "PublisherId", "RentalPrice", "Title", "UnitNumber", "Updated", "UpdatedBy", "UserBasketId", "YearOfPublish" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2298), 1, "Description about the book1", 1, 0.70m, null, 1, 1.20m, "Book1", 3, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2299), 1, null, 1999 },
                    { 2, null, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2301), 1, "Description about the book2", 2, 0.90m, null, 1, 1.50m, "Book2", 3, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2302), 1, null, 1899 },
                    { 3, null, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2306), 1, "Description about the book3", 1, 1.70m, null, 2, 2.20m, "Book3", 3, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2306), 1, null, 2005 },
                    { 4, null, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2308), 1, "Description about the book tesla", 2, 1.30m, null, 3, 1.90m, "Tesla", 5, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2308), 1, null, 2018 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Currency", "Date", "TotalRentalPrice", "TotalRentalPriceWithVAT", "UserId" },
                values: new object[,]
                {
                    { 1, "E", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.20m, 1.50m, 1 },
                    { 2, "U", new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.20m, 1.50m, 2 },
                    { 3, "E", new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.60m, 2m, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserBaskets",
                columns: new[] { "Id", "Currency", "TotalRentalPrice", "TotalRentalPriceWithVAT", "UserId" },
                values: new object[,]
                {
                    { 1, null, 1.20m, 1.50m, 1 },
                    { 2, null, 1.0m, 1.25m, 1 },
                    { 3, null, 1.60m, 2.0m, 2 }
                });

            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "AuthorsId", "BooksId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 3 },
                    { 10, 4 }
                });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "BooksId", "GenresId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "BookRentals",
                columns: new[] { "Id", "BookId", "Created", "CreatedBy", "OrderId", "RentedFromDate", "RentedToDate", "ReturnedDate", "Status", "Updated", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2329), 1, 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2330), 1, 1 },
                    { 2, 1, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2332), 1, 2, new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2333), 1, 2 },
                    { 3, 1, new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2334), 1, 3, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Opened", new DateTime(2022, 7, 5, 17, 9, 50, 892, DateTimeKind.Utc).AddTicks(2335), 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                column: "BooksId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_CountryId",
                table: "Authors",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_GenresId",
                table: "BookGenre",
                column: "GenresId");

            migrationBuilder.CreateIndex(
                name: "IX_BookRentals_OrderId",
                table: "BookRentals",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookRentalId",
                table: "Books",
                column: "BookRentalId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_LanguageId",
                table: "Books",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_OrderId",
                table: "Books",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserBasketId",
                table: "Books",
                column: "UserBasketId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSettings_LanguageId",
                table: "SystemSettings",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBaskets_UserId",
                table: "UserBaskets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DropTable(
                name: "BookGenre");

            migrationBuilder.DropTable(
                name: "SystemSettings");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "BookRentals");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "UserBaskets");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
