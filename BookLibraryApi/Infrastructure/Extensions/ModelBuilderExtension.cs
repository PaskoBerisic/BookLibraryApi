using ApplicationCore.Entities;
using ApplicationCore.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    FirstName = "Name",
                    LastName = "Surname",
                    DateOfBirth = new DateTime(1950, 12, 1),
                    CountryId = 1,
                    Bibliography = "Bibliography 1",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Author
                {
                    Id = 2,
                    FirstName = "Name 2",
                    LastName = "Surname 2",
                    DateOfBirth = new DateTime(1800, 4, 25),
                    CountryId = 3,
                    Bibliography = "Bibliography 2",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Author
                {
                    Id = 3,
                    FirstName = "Name 3",
                    LastName = "Surname 3",
                    DateOfBirth = new DateTime(2000, 3, 12),
                    CountryId = 1,
                    Bibliography = "Bibliography 3",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Author
                {
                    Id = 4,
                    FirstName = "Name 4",
                    LastName = "Surname 4",
                    DateOfBirth = new DateTime(1975, 10, 15),
                    CountryId = 2,
                    Bibliography = "Bibliography 4",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                }
                );
            //Author

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Book 1",
                    PublisherId = 1,
                    YearOfPublish = 1999,
                    Description = "Description about the book 1",
                    LanguageId = 3,
                    RentalPrice = 1.20M,
                    ListPrice = 0.70M,
                    UnitNumber = 3,
                    UnitsRented = 10,
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Book
                {
                    Id = 2,
                    Title = "Book 2",
                    PublisherId = 1,
                    YearOfPublish = 1899,
                    Description = "Description about the book 2",
                    LanguageId = 2,
                    RentalPrice = 1.50M,
                    ListPrice = 0.90M,
                    UnitNumber = 3,
                    UnitsRented = 15,
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Book
                {
                    Id = 3,
                    Title = "Book 3",
                    PublisherId = 2,
                    YearOfPublish = 2005,
                    Description = "Description about the book 3",
                    LanguageId = 1,
                    RentalPrice = 2.20M,
                    ListPrice = 1.70M,
                    UnitNumber = 3,
                    UnitsRented = 2,
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Book
                {
                    Id = 4,
                    Title = "Book 4",
                    PublisherId = 3,
                    YearOfPublish = 1500,
                    Description = "Description about the book 4",
                    LanguageId = 2,
                    RentalPrice = 1.90M,
                    ListPrice = 1.30M,
                    UnitNumber = 5,
                    UnitsRented = 0,
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                }
                );
            //Book

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "England",
                    ShortName = "ENG",
                    VAT = 25,
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Country
                {
                    Id = 2,
                    Name = "France",
                    ShortName = "FRA",
                    VAT = 20,
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Country
                {
                    Id = 3,
                    Name = "Germany",
                    ShortName = "GER",
                    VAT = 10,
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                }
                );
            //Country

            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = 1,
                    Name = "Genre 1",
                    Description = "Description about the genre 1 ",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Genre
                {
                    Id = 2,
                    Name = "Genre 2",
                    Description = "Description about the genre 2",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Genre
                {
                    Id = 3,
                    Name = "Genre 3",
                    Description = "Description about the genre 3",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Genre
                {
                    Id = 4,
                    Name = "Genre 4",
                    Description = "Description about the genre 4",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                }
                );

            //Genre

            modelBuilder.Entity<Language>().HasData(
                new Language
                {
                    Id = 1,
                    Name = "English",
                    ShortName = "Eng",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Language
                {
                    Id = 2,
                    Name = "France",
                    ShortName = "Fra",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Language
                {
                    Id = 3,
                    Name = "Italian",
                    ShortName = "Ita",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                }
                );
            //Language

            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    UserId = 1,
                    Date = new DateTime(2020, 5, 1),
                    TotalRentalPrice = 1.20M,
                    TotalRentalPriceWithVAT = 1.50M,
                    Currency = "EUR"
                },
                new Order
                {
                    Id = 2,
                    UserId = 2,
                    Date = new DateTime(2019, 5, 13),
                    TotalRentalPrice = 1.20M,
                    TotalRentalPriceWithVAT = 1.50M,
                    Currency = "USD"
                },
                new Order
                {
                    Id = 3,
                    UserId = 3,
                    Date = new DateTime(2020, 5, 16),
                    TotalRentalPrice = 1.60M,
                    TotalRentalPriceWithVAT = 2M,
                    Currency = "GBP"
                },
                new Order
                {
                    Id = 4,
                    UserId = 2,
                    Date = new DateTime(2021, 5, 16),
                    TotalRentalPrice = 1.60M,
                    TotalRentalPriceWithVAT = 2M,
                    Currency = "HRK"
                }
                );

            //Order

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher
                {
                    Id = 1,
                    Name = "Publisher 1",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Publisher
                {
                    Id = 2,
                    Name = "Publisher 2",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Publisher
                {
                    Id = 3,
                    Name = "Publisher 3",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                }
                );

            //Publisher

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Name 1",
                    LastName = "Surname 1",
                    Username = "Admin",
                    PasswordCrypted = BCrypt.Net.BCrypt.HashPassword("admin"),
                    Email = "admin@booklibrary.com",
                    IsActive = true,
                    DateOfBirth = new DateTime(1999, 1, 1),
                    Address = "Address 1",
                    Role = Role.Admin,
                    UserBasketId = 1,
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new User
                {
                    Id = 2,
                    FirstName = "Name 2",
                    LastName = "Surname 2",
                    Username = "User2",
                    PasswordCrypted = BCrypt.Net.BCrypt.HashPassword("user"),
                    Email = "user1@booklibrary.com",
                    IsActive = true,
                    DateOfBirth = new DateTime(1999, 1, 1),
                    Address = "Address 2",
                    Role = Role.User,
                    UserBasketId = 2,
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new User
                {
                    Id = 3,
                    FirstName = "Name 3",
                    LastName = "Surname 3",
                    Username = "User3",
                    PasswordCrypted = BCrypt.Net.BCrypt.HashPassword("user"),
                    Email = "user3@booklibrary.com",
                    IsActive = true,
                    DateOfBirth = new DateTime(1999, 1, 1),
                    Address = "Address 3",
                    Role = Role.User,
                    UserBasketId = 3,
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                }
                );

            //User

            modelBuilder.Entity<UserBasket>().HasData(
                new UserBasket
                {
                    Id = 1,
                    Currency = "EUR",
                    TotalRentalPrice = 1.20M,
                    TotalRentalPriceWithVAT = 1.50M
                },
                new UserBasket
                {
                    Id = 2,
                    Currency = "USD",
                    TotalRentalPrice = 1.0M,
                    TotalRentalPriceWithVAT = 1.25M
                },
                new UserBasket
                {
                    Id = 3,
                    Currency = "GBP",
                    TotalRentalPrice = 1.60M,
                    TotalRentalPriceWithVAT = 2.0M
                }
                );

            //UserBasket


            //BookAuthor
            modelBuilder.Entity<BookAuthor>()
                .HasOne(x => x.Book)
                .WithMany(y => y.BookAuthors)
                .HasForeignKey(z => z.BookId);


            modelBuilder.Entity<BookAuthor>()
                 .HasOne(x => x.Author)
                 .WithMany(y => y.BookAuthors)
                 .HasForeignKey(z => z.AuthorId);


            modelBuilder.Entity<BookAuthor>().HasData(
                 new BookAuthor() { Id = 1, BookId = 1, AuthorId = 1 },
                 new BookAuthor() { Id = 2, BookId = 2, AuthorId = 1 },

                 new BookAuthor() { Id = 3, BookId = 1, AuthorId = 2 },
                 new BookAuthor() { Id = 4, BookId = 2, AuthorId = 2 },
                 new BookAuthor() { Id = 5, BookId = 3, AuthorId = 2 },

                 new BookAuthor() { Id = 6, BookId = 1, AuthorId = 3 }
             );
            //BookAuthor


            //BookGenres
            modelBuilder.Entity<BookGenre>()
                .HasOne(x => x.Book)
                .WithMany(y => y.BookGenres)
                .HasForeignKey(z => z.BookId);


            modelBuilder.Entity<BookGenre>()
                 .HasOne(x => x.Genre)
                 .WithMany(y => y.BookGenres)
                 .HasForeignKey(z => z.GenreId);


            modelBuilder.Entity<BookGenre>().HasData(
                 new BookGenre() { Id = 1, BookId = 1, GenreId = 1 },

                 new BookGenre() { Id = 3, BookId = 1, GenreId = 2 },
                 new BookGenre() { Id = 4, BookId = 2, GenreId = 2 },

                 new BookGenre() { Id = 5, BookId = 1, GenreId = 3 },
                 new BookGenre() { Id = 6, BookId = 2, GenreId = 3 },
                 new BookGenre() { Id = 7, BookId = 3, GenreId = 3 }
             );

            //BookUserBasket
            modelBuilder.Entity<BookUserBasket>()
                .HasOne(x => x.Book)
                .WithMany(y => y.BookUserBaskets)
                .HasForeignKey(z => z.BookId);


            modelBuilder.Entity<BookUserBasket>()
                 .HasOne(x => x.UserBasket)
                 .WithMany(y => y.BookUserBaskets)
                 .HasForeignKey(z => z.UserBasketId);


            modelBuilder.Entity<BookUserBasket>().HasData(
                 new BookUserBasket() { Id = 1, BookId = 1, UserBasketId = 1 },
                 new BookUserBasket() { Id = 2, BookId = 2, UserBasketId = 1 },

                 new BookUserBasket() { Id = 3, BookId = 1, UserBasketId = 2 },
                 new BookUserBasket() { Id = 4, BookId = 2, UserBasketId = 2 },
                 new BookUserBasket() { Id = 5, BookId = 3, UserBasketId = 2 },

                 new BookUserBasket() { Id = 6, BookId = 1, UserBasketId = 3 },
                 new BookUserBasket() { Id = 7, BookId = 3, UserBasketId = 3 }
             );
            //BookUserBasket

            // BookOrder
            modelBuilder.Entity<BookOrder>()
                .HasOne(x => x.Book)
                .WithMany(y => y.BookOrders)
                .HasForeignKey(z => z.BookId);


            modelBuilder.Entity<BookOrder>()
                 .HasOne(x => x.Order)
                 .WithMany(y => y.BookOrders)
                 .HasForeignKey(z => z.OrderId);


            modelBuilder.Entity<BookOrder>().HasData(
                 new BookOrder() { Id = 1, BookId = 2, OrderId = 1 },
                 new BookOrder() { Id = 2, BookId = 3, OrderId = 1 },

                 new BookOrder() { Id = 3, BookId = 1, OrderId = 2 },

                 new BookOrder() { Id = 6, BookId = 1, OrderId = 3 },
                 new BookOrder() { Id = 7, BookId = 3, OrderId = 3 }
             );
        }
    }
}
