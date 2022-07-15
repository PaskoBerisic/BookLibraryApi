using BookLibraryApi.Models.Book;

namespace BookLibraryApi.Models.Language
{
    public class LanguagePutModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        // Many to Many
        public ICollection<BookModelShort>? Books { get; set; }

    }
}
