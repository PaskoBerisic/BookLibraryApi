using ApplicationCore.Entities;
using BookLibraryApi.Models.Book;

namespace BookLibraryApi.Models
{
    public class UserBasketModel
    {
        public int Id { get; set; }
        public decimal TotalRentalPrice { get; set; }
        public decimal TotalRentalPriceWithVAT { get; set; }
        public string? Currency { get; set; }
        public ICollection<BookModel>? Books { get; set; }
    }
}
