using BookLibraryApi.Models.Country;

namespace BookLibraryApi.Models.Author
{
    public class AuthorPutModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CountryModelShort Country { get; set; }
        public string? Bibliography { get; set; }

    }
}
