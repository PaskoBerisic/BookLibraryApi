using ApplicationCore.Entities;
using BookLibraryApi.Models.Book;
using BookLibraryApi.Models.Country;

namespace BookLibraryApi.Models
{
    public class AuthorModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<BookModel>? Books { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CountryModel? Country { get; set; }
        public string? Bibliography { get; set; }
        
    }
}
