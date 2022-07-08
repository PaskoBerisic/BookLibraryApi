using BookLibraryApi.Models.Book;
using BookLibraryApi.Models.User;

namespace BookLibraryApi.Models.BookRental
{
    public class BookRentalModelShort
    {
        public BookModelShort Books { get; set; }
        public UserModelShort User { get; set; }
        public string? Status { get; set; }

    }
}
