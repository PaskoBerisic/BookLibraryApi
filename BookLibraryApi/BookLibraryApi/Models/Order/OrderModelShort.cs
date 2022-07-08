using BookLibraryApi.Models.BookRental;

namespace BookLibraryApi.Models.Order
{
    public class OrderModelShort
    {
        public ICollection<BookRentalModelShort> RentedBooks { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalRentalPrice { get; set; }

    }
}
