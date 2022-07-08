using ApplicationCore.Entities;

namespace BookLibraryApi.Models
{
    public class UserBasketModel
    {
        public int Id { get; set; }
        public ICollection<BookRentalModel>? RentedBooks { get; set; }
        public decimal TotalRentalPrice { get; set; }
        public decimal TotalRentalPriceWithVAT { get; set; }
        public string? Currency { get; set; }

    }
}
