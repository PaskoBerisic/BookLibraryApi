using ApplicationCore.Entities;

namespace BookLibraryWebAPI.Models
{
    public class AuthorModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public ICollection<Book>? Books { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Country? Country { get; set; }
        public string? Bibliography { get; set; }
        
    }
}
