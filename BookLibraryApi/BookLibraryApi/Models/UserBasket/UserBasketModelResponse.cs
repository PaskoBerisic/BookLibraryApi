using BookLibraryApi.Models.Book;
using BookLibraryApi.Models.User;

namespace BookLibraryApi.Models.UserBasket
{
    public class UserBasketModelResponse
    {
        public int Id { get; set; }
        public decimal TotalRentalPrice { get { return Books.Sum(x => x.RentalPrice); } }
        public decimal TotalRentalPriceWithVAT { get { return TotalRentalPrice * 1.25M; } }
        public string? Currency { get; set; }

        public UserModelResponse? User { get; set; }
        public ICollection<BookModelResponse>? Books { get; set; }
    }
}
