using BookLibraryApi.Models.BookRental;

namespace BookLibraryApi.Models.Order
{
    public class OrderPutModel
    {
        public int Id { get; set; }
        public ICollection<BookRentalModelShort> RentedBooks { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalRentalPrice { get; set; }
        public decimal TotalRentalPriceWithVAT { get; set; }
        public string? Currency { get; set; }

    }
}
