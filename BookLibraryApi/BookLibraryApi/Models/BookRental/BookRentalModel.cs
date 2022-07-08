using ApplicationCore.Entities;
using BookLibraryApi.Models.Book;
using BookLibraryApi.Models.User;

namespace BookLibraryApi.Models
{
    public class BookRentalModel
    {
        public int Id { get; set; }
        public BookModel Books { get; set; }
        public UserModel User { get; set; }
        public DateTime RentedFromDate { get; set; }
        public DateTime RentedToDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public string? Status { get; set; }
    }
}
