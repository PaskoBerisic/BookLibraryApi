using ApplicationCore.Entities;

namespace BookLibraryWebAPI.Models
{
    public class BookRentalModel
    {

        public Book? Book { get; set; }
        public User? User { get; set; }
        public DateTime RentedFromDate { get; set; }
        public DateTime RentedToDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public string? Status { get; set; }
    }
}
