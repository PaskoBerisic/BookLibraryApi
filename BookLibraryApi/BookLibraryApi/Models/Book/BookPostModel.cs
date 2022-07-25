using BookLibraryApi.Models.Genre;
using BookLibraryApi.Models.Language;
using BookLibraryApi.Models.Order;
using BookLibraryApi.Models.Publisher;

namespace BookLibraryApi.Models.Book
{
    public class BookPostModel
    {
        public string? Title { get; set; }
        public int YearOfPublish { get; set; }
        public string? Description { get; set; }
        public decimal RentalPrice { get; set; }
        public int UnitNumber { get; set; }
        public int UnitsRented { get; set; }
        // One to Many
        public int PublisherId { get; set; }
        public int LanguageId { get; set; }
        // Many to Many
        public ICollection<AuthorModelShort>? Authors { get; set; }
        public ICollection<GenreModelShort>? Genres { get; set; }
        public ICollection<OrderModelShort>? Orders { get; set; }

    }
}
