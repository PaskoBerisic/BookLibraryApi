using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Migration001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
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
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
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
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
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
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
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
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
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
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserBasket",
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
                    table.PrimaryKey("PK_UserBasket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Author",
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
                    table.PrimaryKey("PK_Author", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Author_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
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
                        name: "FK_SystemSettings_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
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
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Book",
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
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    UserBasketId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Book_Publisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_UserBasket_UserBasketId",
                        column: x => x.UserBasketId,
                        principalTable: "UserBasket",
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
                        name: "FK_AuthorBook_Author_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Book_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Book",
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
                        name: "FK_BookGenre_Book_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenre_Genre_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookRental",
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
                    table.PrimaryKey("PK_BookRental", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookRental_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookRental_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade); 
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Created", "CreatedBy", "Name", "ShortName", "Updated", "UpdatedBy", "VAT" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1975), 1, "England", "Eng", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1976), 1, 25 },
                    { 2, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1977), 1, "France", "Fra", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1978), 1, 20 },
                    { 3, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1979), 1, "Germany", "GER", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1979), 1, 10 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "IsActive", "Name", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2000), 1, "Description about the genre 1 ", true, "Genre 1", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2000), 1 },
                    { 2, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2002), 1, "Description about the genre 2", false, "Genre 2", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2003), 1 },
                    { 3, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2004), 1, "Description about the genre 3", true, "Genre 3", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2004), 1 }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Created", "CreatedBy", "Name", "ShortName", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2023), 1, "English", "Eng", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2024), 1 },
                    { 2, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2026), 1, "France", "Fra", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2026), 1 },
                    { 3, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2027), 1, "German", "Ger", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2027), 1 }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Created", "CreatedBy", "Name", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2067), 1, "Publisher 1", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2067), 1 },
                    { 2, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2069), 1, "Publisher 2", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2069), 1 },
                    { 3, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2070), 1, "Publisher 3", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2070), 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Adress", "Created", "CreatedBy", "DateOfBirth", "FirstName", "IsActive", "LastName", "Password", "Role", "Updated", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { 1, "Adresa 1", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2087), 1, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name 1", true, "Surname 1", "123456", 0, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2088), 1, "User1" },
                    { 2, "Adresa 2", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2090), 1, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name 2", true, "Surname 2", "123456", 0, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2091), 1, "User2" },
                    { 3, "Adresa 2", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2092), 1, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name 2", true, "Surname 2", "123456", 0, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(2093), 1, "User2" }
                });

            migrationBuilder.InsertData(
                table: "UserBasket",
                columns: new[] { "Id", "Currency", "TotalRentalPrice", "TotalRentalPriceWithVAT", "UserId" },
                values: new object[,]
                {
                    { 1, null, 1.20m, 1.50m, 1 },
                    { 2, null, 1.0m, 1.25m, 1 },
                    { 3, null, 1.60m, 2.0m, 2 }
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Bibliography", "CountryId", "Created", "CreatedBy", "DateOfBirth", "FirstName", "LastName", "Updated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Bibliography 1", 1, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1765), 1, new DateTime(1950, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name", "Surname", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1766), 1 },
                    { 2, "Bibliography 2", 1, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1768), 1, new DateTime(1950, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name 2", "Surname 2", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1769), 1 },
                    { 3, "Bibliography 3", 1, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1770), 1, new DateTime(1950, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Name 3", "Surname 3", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1771), 1 }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "LanguageId", "ListPrice", "OrderId", "PublisherId", "RentalPrice", "Title", "UnitNumber", "Updated", "UpdatedBy", "UserBasketId", "YearOfPublish" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1911), 1, "Description about the book1", 1, 0.70m, null, 1, 1.20m, "Book1", 3, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1912), 1, null, 1999 },
                    { 2, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1914), 1, "Description about the book2", 2, 0.90m, null, 1, 1.50m, "Book2", 3, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1915), 1, null, 1899 },
                    { 3, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1918), 1, "Description about the book3", 1, 1.70m, null, 2, 2.20m, "Book3", 3, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1918), 1, null, 2005 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "Currency", "Date", "TotalRentalPrice", "TotalRentalPriceWithVAT", "UserId" },
                values: new object[,]
                {
                    { 1, "E", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.20m, 1.50m, 1 },
                    { 2, "U", new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.20m, 1.50m, 2 },
                    { 3, "E", new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.60m, 2m, 1 }
                });

            migrationBuilder.InsertData(
                table: "AuthorBook",
                columns: new[] { "AuthorsId", "BooksId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "BooksId", "GenresId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "BookRental",
                columns: new[] { "Id", "BookId", "Created", "CreatedBy", "OrderId", "RentedFromDate", "RentedToDate", "ReturnedDate", "Status", "Updated", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1948), 1, 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1949), 1, 1 },
                    { 2, 1, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1952), 1, 2, new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Closed", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1953), 1, 2 },
                    { 3, 1, new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1954), 1, 3, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Opened", new DateTime(2022, 6, 25, 10, 26, 16, 187, DateTimeKind.Utc).AddTicks(1955), 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Author_CountryId",
                table: "Author",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                column: "BooksId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_LanguageId",
                table: "Book",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_OrderId",
                table: "Book",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublisherId",
                table: "Book",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_UserBasketId",
                table: "Book",
                column: "UserBasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_GenresId",
                table: "BookGenre",
                column: "GenresId");

            migrationBuilder.CreateIndex(
                name: "IX_BookRental_BookId",
                table: "BookRental",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookRental_UserId",
                table: "BookRental",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSettings_LanguageId",
                table: "SystemSettings",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DropTable(
                name: "BookGenre");

            migrationBuilder.DropTable(
                name: "BookRental");

            migrationBuilder.DropTable(
                name: "SystemSettings");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropTable(
                name: "UserBasket");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
