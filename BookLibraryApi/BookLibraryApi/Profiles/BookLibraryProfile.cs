using ApplicationCore.Entities;
using AutoMapper;
using BookLibraryApi.Models;
using BookLibraryApi.Models.Author;
using BookLibraryApi.Models.Book;
using BookLibraryApi.Models.BookRental;
using BookLibraryApi.Models.Country;
using BookLibraryApi.Models.Genre;
using BookLibraryApi.Models.Language;
using BookLibraryApi.Models.Order;
using BookLibraryApi.Models.Publisher;
using BookLibraryApi.Models.User;

namespace BookLibraryApi.Profiles
{
    public class BookLibraryProfile : Profile
    {
        public BookLibraryProfile()
        {
            CreateMap<Book, BookModel>().ReverseMap();
            CreateMap<Book, BookModelRequest>().ReverseMap();
            CreateMap<Book, BookPostModel>().ReverseMap();
            CreateMap<Book, BookPutModel>().ReverseMap();
            CreateMap<Book, BookModelShort>().ReverseMap();

            CreateMap<Author, AuthorModel>().ReverseMap();
            CreateMap<Author, AuthorModelRequest>().ReverseMap();
            CreateMap<Author, AuthorPostModel>().ReverseMap();
            CreateMap<Author, AuthorPutModel>().ReverseMap();
            CreateMap<Author, AuthorModelShort>().ReverseMap();

            CreateMap<BookRental, BookRentalModel>().ReverseMap();
            CreateMap<BookRental, BookRentalModelShort>().ReverseMap();

            CreateMap<Country, CountryModel>().ReverseMap();
            CreateMap<Country, CountryModelRequest>().ReverseMap();
            CreateMap<Country, CountryModelShort>().ReverseMap();

            CreateMap<Genre, GenreModel>().ReverseMap();
            CreateMap<Genre, GenreModelRequest>().ReverseMap();
            CreateMap<Genre, GenrePostModel>().ReverseMap();
            CreateMap<Genre, GenrePutModel>().ReverseMap();
            CreateMap<Genre, GenreModelShort>().ReverseMap();

            CreateMap<Language, LanguageModel>().ReverseMap();
            CreateMap<Language, LanguageModelRequest>().ReverseMap();
            CreateMap<Language, LanguagePutModel>().ReverseMap();
            CreateMap<Language, LanguageModelShort>().ReverseMap();

            CreateMap<Order, OrderModel>().ReverseMap();
            CreateMap<Order, OrderModelRequest>().ReverseMap();
            CreateMap<Order, OrderPostModel>().ReverseMap();
            CreateMap<Order, OrderPutModel>().ReverseMap();
            CreateMap<Order, OrderModelShort>().ReverseMap();

            CreateMap<Publisher, PublisherModel>().ReverseMap();
            CreateMap<Publisher, PublisherModelRequest>().ReverseMap();
            CreateMap<Publisher, PublisherModelShort>().ReverseMap();

            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<User, UserModelRequest>().ReverseMap();
            CreateMap<User, UserModelShort>().ReverseMap();

            CreateMap<UserBasket, UserBasketModel>().ReverseMap();

        }
    }
}
