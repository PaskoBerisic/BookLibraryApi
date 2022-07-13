using BookLibraryApi.Models.Book;

namespace BookLibraryApi.Models.Language
{
    public class LanguagePostModel
    {
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        // Many to Many
        public ICollection<BookModelShort> Books { get; set; }
    }
}
