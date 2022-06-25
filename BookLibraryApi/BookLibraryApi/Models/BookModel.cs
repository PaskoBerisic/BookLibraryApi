using ApplicationCore.Entities;

namespace BookLibraryWebAPI.Models
{
    public class BookModel
    {

        public string? Title { get; set; }
        public ICollection<Author>? Authors { get; set; }
        public Publisher? Publisher { get; set; }
        public int YearOfPublish { get; set; }
        public string? Description { get; set; }
        public ICollection<Genre>? Genres { get; set; }
        public Language? Language { get; set; }
        public decimal RentalPrice { get; set; }
        public decimal ListPrice { get; set; }
    }
}
