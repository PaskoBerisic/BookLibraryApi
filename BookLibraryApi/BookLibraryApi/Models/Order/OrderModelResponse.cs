using BookLibraryApi.Models.Book;
using BookLibraryApi.Models.User;

namespace BookLibraryApi.Models.Order
{
    public class OrderModelResponse
    {
        public int Id { get; set; }
        public decimal TotalRentalPrice { get { return Books != null ? Books.Sum(x => x.RentalPrice) : 0; } }
        public decimal TotalRentalPriceWithVAT { get { return TotalRentalPrice * 1.25M; } }
        public string? Currency { get; set; }
        public DateTime Date { get; set; }

        public UserModelResponse? User { get; set; }
        public ICollection<BookModelResponse>? Books { get; set; }

    }
}
