using ApplicationCore.Entities;
using AutoMapper;
using BookLibraryApi.Models;
using BookLibraryApi.Models.Author;
using BookLibraryApi.Models.Book;
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

            CreateMap<Author, AuthorModel>().ReverseMap();
            CreateMap<Author, AuthorModelRequest>().ReverseMap();

            CreateMap<BookRental, BookRentalModel>().ReverseMap();

            CreateMap<Country, CountryModel>().ReverseMap();
            CreateMap<Country, CountryModelRequest>().ReverseMap();

            CreateMap<Genre, GenreModel>().ReverseMap();
            CreateMap<Genre, GenreModelRequest>().ReverseMap();
            
            CreateMap<Language, LanguageModel>().ReverseMap();
            CreateMap<Language, LanguageModelRequest>().ReverseMap();
            
            CreateMap<Order, OrderModel>().ReverseMap();
            CreateMap<Order, OrderModelRequest>().ReverseMap();
            
            CreateMap<Publisher, PublisherModel>().ReverseMap();
            CreateMap<Publisher, PublisherModelRequest>().ReverseMap();

            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<User, UserModelRequest>().ReverseMap();

            CreateMap<UserBasket, UserBasketModel>().ReverseMap();

        }
    }
}
