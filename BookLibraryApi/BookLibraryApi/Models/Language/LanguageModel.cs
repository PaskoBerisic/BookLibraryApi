using BookLibraryApi.Models.Book;

namespace BookLibraryApi.Models
{
    public class LanguageModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public ICollection<BookModel>? Books { get; set; }
    }
}
