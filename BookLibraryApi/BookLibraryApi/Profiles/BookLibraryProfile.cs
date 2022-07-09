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
            CreateMap<Author, AuthorModel>().ReverseMap();
            CreateMap<Author, AuthorPostModel>().ReverseMap();
            CreateMap<Author, AuthorModelShort>().ReverseMap();

            CreateMap<Book, BookModel>().ReverseMap();
            CreateMap<Book, BookPostModel>().ReverseMap();
            CreateMap<Book, BookModelShort>().ReverseMap();

            CreateMap<BookRental, BookRentalModel>().ReverseMap();
            CreateMap<BookRental, BookRentalModelShort>().ReverseMap();

            CreateMap<Country, CountryModel>().ReverseMap();
            CreateMap<Country, CountryModelShort>().ReverseMap();

            CreateMap<Genre, GenreModel>().ReverseMap();
            CreateMap<Genre, GenrePostModel>().ReverseMap();
            CreateMap<Genre, GenreModelShort>().ReverseMap();

            CreateMap<Language, LanguageModel>().ReverseMap();
            CreateMap<Language, LanguagePostModel>().ReverseMap();
            CreateMap<Language, LanguageModelShort>().ReverseMap();

            CreateMap<Order, OrderModel>().ReverseMap();
            CreateMap<Order, OrderPostModel>().ReverseMap();
            CreateMap<Order, OrderModelShort>().ReverseMap();

            CreateMap<Publisher, PublisherModel>().ReverseMap();
            CreateMap<Publisher, PublisherPostModel>().ReverseMap();
            CreateMap<Publisher, PublisherPostModel>().ReverseMap();

            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<User, UserPostModel>().ReverseMap();
            CreateMap<User, UserModelShort>().ReverseMap();

            CreateMap<UserBasket, UserBasketModel>().ReverseMap();

        }
    }
}
