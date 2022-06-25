using ApplicationCore.Entities;
using AutoMapper;
using BookLibraryWebAPI.Models;

namespace BookLibraryApi.Profiles
{
    public class BookLibraryProfile : Profile
    {
        public BookLibraryProfile()
        {
            CreateMap<Book, BookModel>().ReverseMap();
            CreateMap<Author, AuthorModel>().ReverseMap();
            CreateMap<Order, OrderModel>().ReverseMap();

        }
    }
}
