using BookLibraryApi.Models.Book;
using BookLibraryApi.Models.User;

namespace BookLibraryApi.Models.BookRental
{
    public class BookRentalModelShort
    {
        public UserModel? User { get; set; }
        public OrderModel? Order { get; set; }
        public string? Status { get; set; }

    }
}
