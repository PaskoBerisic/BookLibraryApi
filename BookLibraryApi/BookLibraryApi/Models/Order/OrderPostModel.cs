using BookLibraryApi.Models.Book;

namespace BookLibraryApi.Models.Order
{
    public class OrderPostModel
    {
        public DateTime Date { get; set; }
        public decimal TotalRentalPrice { get; set; }
        public decimal TotalRentalPriceWithVAT { get; set; }
        public string? Currency { get; set; }
        // One to Many
        public int UserId { get; set; }
        // Many to Many
        public ICollection<BookModelShort>? Books { get; set; }

    }
}
