using BookLibraryApi.Models.Book;

namespace BookLibraryApi.Models.Genre
{
    public class GenrePostModel
    {
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public string? Description { get; set; }
        // Many to Many
        //public ICollection<BookModelShort>? Books { get; set; }
    }
}
