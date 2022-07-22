using BookLibraryApi.Models.Book;

namespace BookLibraryApi.Models.UserBasket
{
    public class UserBasketPutModel
    {
        public int Id { get; set; }
        public decimal TotalRentalPrice { get; set; }
        public decimal TotalRentalPriceWithVAT { get; set; }
        public string? Currency { get; set; }
        public int UserId { get; set; }
        public ICollection<BookModelShort>? Books { get; set; }

    }
}
