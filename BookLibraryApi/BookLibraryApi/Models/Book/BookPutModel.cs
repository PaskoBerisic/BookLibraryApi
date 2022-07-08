using BookLibraryApi.Models.Genre;
using BookLibraryApi.Models.Language;
using BookLibraryApi.Models.Publisher;

namespace BookLibraryApi.Models.Book
{
    public class BookPutModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public ICollection<AuthorModelShort>? Authors { get; set; }
        public PublisherModelShort Publisher { get; set; }
        public int YearOfPublish { get; set; }
        public string? Description { get; set; }
        public ICollection<GenreModelShort>? Genres { get; set; }
        public LanguageModelShort Language { get; set; }
        public decimal RentalPrice { get; set; }
        public int UnitNumber { get; set; }

    }
}
