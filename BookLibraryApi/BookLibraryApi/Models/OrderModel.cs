using ApplicationCore.Entities;

namespace BookLibraryWebAPI.Models
{
    public class OrderModel
    {
        public ICollection<BookRental>? RentedBooks { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalRentalPrice { get; set; }
        public decimal TotalRentalPriceWithVAT { get; set; }
        public string? Currency { get; set; }

    }
}
