using BookLibraryApi.Models.Country;

namespace BookLibraryApi.Models.Author
{
    public class AuthorPostModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CountryModel Country { get; set; }
        public string? Bibliography { get; set; }

    }
}
