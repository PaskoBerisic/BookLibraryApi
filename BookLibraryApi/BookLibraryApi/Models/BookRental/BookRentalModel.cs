using ApplicationCore.Entities;
using BookLibraryApi.Models.Book;
using BookLibraryApi.Models.User;

namespace BookLibraryApi.Models
{
    public class BookRentalModel
    {
        public int Id { get; set; }
        public DateTime RentedFromDate { get; set; }
        public DateTime RentedToDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public string? Status { get; set; }
        // One to Many
        public int UserId { get; set; }
        public int OrderId { get; set; }
    }
}
