using BookLibraryApi.Models.Book;
using BookLibraryApi.Models.Country;

namespace BookLibraryApi.Models.Author
{
    public class AuthorPostModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Bibliography { get; set; }
        // One to Many
        public int CountryId { get; set; }
        // Many to Many
        public ICollection<BookModelShort> Books { get; set; }
    }
}
