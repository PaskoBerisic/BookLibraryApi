using ApplicationCore.Entities;
using AutoMapper;
using BookLibraryApi.Models;
using BookLibraryApi.Models.Book;
using BookLibraryApi.Models.Country;
using BookLibraryApi.Models.Genre;
using BookLibraryApi.Models.Order;
using BookLibraryApi.Models.User;
using BookLibraryApi.Models.UserBasket;

namespace BookLibraryApi.Profiles
{
    public class BookLibraryProfile : Profile
    {
        public BookLibraryProfile()
        {
            CreateMap<Author, AuthorModelRequest>().ReverseMap();
            CreateMap<Author, AuthorModelResponse>().ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.BookAuthors.Select(x => x.Book))).ReverseMap();

            CreateMap<Book, BookModelRequest>().ReverseMap();
            CreateMap<Book, BookModelResponse>().ForMember(dest => dest.Authors, opt => opt.MapFrom(src => src.BookAuthors.Select(x => x.Author)))
                                                .ForMember(dest => dest.Genres, opt => opt.MapFrom(src => src.BookGenres.Select(x => x.Genre)))
                                                .ForMember(dest => dest.UserBaskets, opt => opt.MapFrom(src => src.BookUserBaskets.Select(x => x.UserBasket))).ReverseMap();

            CreateMap<Country, CountryModel>().ReverseMap();
            
            CreateMap<Genre, GenreModelRequest>().ReverseMap();
            CreateMap<Genre, GenreModelResponse>().ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.BookGenres.Select(x => x.Book))).ReverseMap();

            CreateMap<Language, LanguageModel>().ReverseMap();

            CreateMap<Order, OrderModelRequest>().ReverseMap();
            CreateMap<Order, OrderModelResponse>().ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.BookOrders.Select(x => x.Book))).ReverseMap();

            CreateMap<Publisher, PublisherModel>().ReverseMap();

            CreateMap<User, UserModelResponse>().ReverseMap();
            CreateMap<User, UserModelRequest>().ReverseMap();

            CreateMap<UserBasket, UserBasketModelRequest>().ReverseMap();
            CreateMap<UserBasket, UserBasketModelResponse>().ForMember(dest => dest.Books, opt => opt.MapFrom(src => src.BookUserBaskets.Select(x => x.Book))).ReverseMap();
        }
    }
}
