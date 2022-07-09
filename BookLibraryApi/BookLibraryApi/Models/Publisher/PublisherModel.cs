using BookLibraryApi.Models.Book;

namespace BookLibraryApi.Models
{
    public class PublisherModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        // Many to Many
        public ICollection<BookModel>? Books { get; set; }
    }
}
