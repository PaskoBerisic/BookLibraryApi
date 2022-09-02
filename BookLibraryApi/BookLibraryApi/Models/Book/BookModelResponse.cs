using BookLibraryApi.Models.Genre;
using BookLibraryApi.Models.Order;
using BookLibraryApi.Models.UserBasket;

namespace BookLibraryApi.Models.Book
{
    public class BookModelResponse
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int YearOfPublish { get; set; }
        public string? Description { get; set; }
        public decimal RentalPrice { get; set; }
        public decimal ListPrice { get; set; }
        public int UnitNumber { get; set; }

        public LanguageModel? Language { get; set; }
        public PublisherModel? Publisher { get; set; }

        public ICollection<AuthorModelResponse>? Authors { get; set; }
        public ICollection<GenreModelResponse>? Genres { get; set; }
        public ICollection<OrderModelResponse>? Orders { get; set; }
        public ICollection<UserBasketModelResponse>? UserBaskets { get; set; }
    }
}
