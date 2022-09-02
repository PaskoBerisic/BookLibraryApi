using BookLibraryApi.Models.Book;

namespace BookLibraryApi.Models.Genre
{
    public class GenreModelResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public ICollection<BookModelResponse>? Books { get; set; }
    }
}
