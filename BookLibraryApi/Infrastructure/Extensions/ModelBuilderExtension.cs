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
                    DateOfBirth = new DateTime(1950, 12, 1),
                    CountryId = 1,
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
                    DateOfBirth = new DateTime(1950, 12, 1),
                    CountryId = 1,
                    Bibliography = "Bibliography 3",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Author
                {
                    Id = 10,
                    FirstName = "Elon",
                    LastName = "Musk",
                    DateOfBirth = new DateTime(1975, 10, 15),
                    CountryId = 2,
                    Bibliography = "Bibliography 8",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                }
                );

            //Author With Many Books
            modelBuilder.Entity<Author>()
                .HasMany(x => x.Books)
                .WithMany(x => x.Authors)
                .UsingEntity(x => x.HasData(
                    new
                    {
                        BooksId = 1,
                        AuthorsId = 1
                    },
                    new
                    {
                        BooksId = 2,
                        AuthorsId = 1
                    },
                    new
                    {
                        BooksId = 2,
                        AuthorsId = 2
                    },
                    new
                    {
                        BooksId = 3,
                        AuthorsId = 3
                    },
                    new
                    {
                        BooksId = 4,
                        AuthorsId = 10
                    }
                    ));
            //Author

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Book1",
                    PublisherId = 1,
                    YearOfPublish = 1999,
                    Description = "Description about the book1",
                    LanguageId = 1,
                    RentalPrice = 1.20M,
                    ListPrice = 0.70M,
                    UnitNumber = 3,
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Book
                {
                    Id = 2,
                    Title = "Book2",
                    PublisherId = 1,
                    YearOfPublish = 1899,
                    Description = "Description about the book2",
                    LanguageId = 2,
                    RentalPrice = 1.50M,
                    ListPrice = 0.90M,
                    UnitNumber = 3,
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Book
                {
                    Id = 3,
                    Title = "Book3",
                    PublisherId = 2,
                    YearOfPublish = 2005,
                    Description = "Description about the book3",
                    LanguageId = 1,
                    RentalPrice = 2.20M,
                    ListPrice = 1.70M,
                    UnitNumber = 3,
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Book
                {
                    Id = 4,
                    Title = "Tesla",
                    PublisherId = 3,
                    YearOfPublish = 2018,
                    Description = "Description about the book tesla",
                    LanguageId = 2,
                    RentalPrice = 1.90M,
                    ListPrice = 1.30M,
                    UnitNumber = 5,
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                }
                );
            //Book

            modelBuilder.Entity<BookRental>().HasData(
                new BookRental
                {
                    Id = 1,
                    //UserId = 1,
                    OrderId = 1,
                    RentedFromDate = new DateTime(2020, 1, 1),
                    RentedToDate = new DateTime(2020, 1, 5),
                    ReturnedDate = new DateTime(2020, 1, 4),
                    Status = "Closed",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new BookRental
                {
                    Id = 2,
                    //UserId = 2,
                    OrderId = 2,
                    RentedFromDate = new DateTime(2020, 1, 5),
                    RentedToDate = new DateTime(2020, 1, 15),
                    ReturnedDate = new DateTime(2020, 1, 16),
                    Status = "Closed",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new BookRental
                {
                    Id = 3,
                    //UserId = 1,
                    OrderId = 3,
                    RentedFromDate = new DateTime(2020, 1, 6),
                    RentedToDate = new DateTime(2020, 1, 10),
                    ReturnedDate = new DateTime(),
                    Status = "Opened",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                }
                );
            
            //BookRental

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "England",
                    ShortName = "Eng",
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
                    ShortName = "Fra",
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
                    IsActive = true,
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
                    IsActive = false,
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
                    IsActive = true,
                    Description = "Description about the genre 3",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                },
                new Genre
                {
                    Id = 4,
                    Name = "Documentary",
                    IsActive = true,
                    Description = "Description about the genre 3",
                    CreatedBy = 1,
                    Created = DateTime.UtcNow,
                    UpdatedBy = 1,
                    Updated = DateTime.UtcNow
                }
                );

            //Genre With Many Books
            modelBuilder.Entity<Genre>()
                .HasMany(x => x.Books)
                .WithMany(x => x.Genres)
                .UsingEntity(x => x.HasData(
                    new
                    {
                        BooksId = 1,
                        GenresId = 1
                    },
                    new
                    {
                        BooksId = 2,
                        GenresId = 1
                    },
                    new
                    {
                        BooksId = 2,
                        GenresId = 2
                    },
                    new
                    {
                        BooksId = 3,
                        GenresId = 3
                    },
                    new
                    {
                        BooksId = 4,
                        GenresId = 4
                    }
                    ));

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
                    Name = "German",
                    ShortName = "Ger",
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
                    Currency = "E"
                },
                new Order
                {
                    Id = 2,
                    UserId = 2,
                    Date = new DateTime(2020, 5, 13),
                    TotalRentalPrice = 1.20M,
                    TotalRentalPriceWithVAT = 1.50M,
                    Currency = "U"
                },
                new Order
                {
                    Id = 3,
                    UserId = 3,
                    Date = new DateTime(2020, 5, 16),
                    TotalRentalPrice = 1.60M,
                    TotalRentalPriceWithVAT = 2M,
                    Currency = "E"
                },
                new Order
                {
                    Id = 4,
                    UserId = 2,
                    Date = new DateTime(2021, 5, 16),
                    TotalRentalPrice = 1.60M,
                    TotalRentalPriceWithVAT = 2M,
                    Currency = "E"
                }
                );
            //Order With Many Books
            modelBuilder.Entity<Order>()
                .HasMany(x => x.Books)
                .WithMany(x => x.Orders)
                .UsingEntity(x => x.HasData(
                    new
                    {
                        BooksId = 1,
                        OrdersId = 1
                    },
                    new
                    {
                        BooksId = 2,
                        OrdersId = 1
                    },
                    new
                    {
                        BooksId = 4,
                        OrdersId = 2
                    },
                    new
                    {
                        BooksId = 3,
                        OrdersId = 3
                    },
                    new
                    {
                        BooksId = 2,
                        OrdersId = 3
                    },
                    new
                    {
                        BooksId = 1,
                        OrdersId = 4
                    },
                    new
                    {
                        BooksId = 19,
                        OrdersId = 4
                    }
                    ));
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
                    Username = "User1",
                    Password = "123456",
                    IsActive = true,
                    DateOfBirth = new DateTime(1999, 1, 1),
                    Adress = "Adresa 1",
                    Role = Role.Admin,
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
                    Password = "123456",
                    IsActive = true,
                    DateOfBirth = new DateTime(1999, 1, 1),
                    Adress = "Adresa 2",
                    Role = Role.Admin,
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
                    Password = "123456",
                    IsActive = true,
                    DateOfBirth = new DateTime(1999, 1, 1),
                    Adress = "Adresa 2",
                    Role = Role.Admin,
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
                    UserId = 1,
                    TotalRentalPrice = 1.20M,
                    TotalRentalPriceWithVAT = 1.50M
                },
                new UserBasket
                {
                    Id = 2,
                    UserId = 1,
                    TotalRentalPrice = 1.0M,
                    TotalRentalPriceWithVAT = 1.25M
                },
                new UserBasket
                {
                    Id = 3,
                    UserId = 2,
                    TotalRentalPrice = 1.60M,
                    TotalRentalPriceWithVAT = 2.0M
                }
                );
            //UserBasket
        }

    }
}
