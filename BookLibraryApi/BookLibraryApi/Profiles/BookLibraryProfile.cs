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
using BookLibraryApi.Models.UserBasket;

namespace BookLibraryApi.Profiles
{
    public class BookLibraryProfile : Profile
    {
        public BookLibraryProfile()
        {
            CreateMap<Author, AuthorModelRequest>().ReverseMap();
            CreateMap<Author, AuthorModelShort>().ReverseMap();
            CreateMap<Author, AuthorPostModel>().ReverseMap();
            CreateMap<Author, AuthorPutModel>().ReverseMap();

            CreateMap<Book, BookModelRequest>().ReverseMap();
            CreateMap<Book, BookModelResponse>().ReverseMap();
            CreateMap<Book, BookPostModel>().ReverseMap();
            CreateMap<Book, BookPutModel>().ReverseMap();

            CreateMap<BookRental, BookRentalModel>().ReverseMap();
            CreateMap<BookRental, BookRentalModelShort>().ReverseMap();

            CreateMap<Country, CountryModel>().ReverseMap();
            CreateMap<Country, CountryModel>().ReverseMap();
            CreateMap<Country, CountryPostModel>().ReverseMap();
            CreateMap<Country, CountryPutModel>().ReverseMap();

            CreateMap<Genre, GenreModelRequest>().ReverseMap();
            CreateMap<Genre, GenreModelResponse>().ReverseMap();
            CreateMap<Genre, GenrePostModel>().ReverseMap();
            CreateMap<Genre, GenrePutModel>().ReverseMap();

            CreateMap<Language, LanguageModel>().ReverseMap();
            CreateMap<Language, LanguageModelShort>().ReverseMap();
            CreateMap<Language, LanguagePostModel>().ReverseMap();
            CreateMap<Language, LanguagePutModel>().ReverseMap();


            CreateMap<Order, OrderModelRequest>().ReverseMap();
            CreateMap<Order, OrderModelResponse>().ReverseMap();
            CreateMap<Order, OrderPostModel>().ReverseMap();
            CreateMap<Order, OrderPutModel>().ReverseMap();

            CreateMap<Publisher, PublisherModel>().ReverseMap();
            CreateMap<Publisher, PublisherPostModel>().ReverseMap();
            CreateMap<Publisher, PublisherPostModel>().ReverseMap();
            CreateMap<Publisher, PublisherPutModel>().ReverseMap();

            CreateMap<User, UserModelRequest>().ReverseMap();
            CreateMap<User, UserModelResponse>().ReverseMap();
            CreateMap<User, UserPostModel>().ReverseMap();
            CreateMap<User, UserPutModel>().ReverseMap();

            CreateMap<UserBasket, UserBasketModelRequest>().ReverseMap();
            CreateMap<UserBasket, UserBasketPostModel>().ReverseMap();
            CreateMap<UserBasket, UserBasketPutModel>().ReverseMap();
        }
    }
}
