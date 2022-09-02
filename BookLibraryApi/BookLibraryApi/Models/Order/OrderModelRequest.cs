using BookLibraryApi.Models.Book;

namespace BookLibraryApi.Models
{
    public class OrderModelRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal TotalRentalPrice { get; set; }
        public decimal TotalRentalPriceWithVAT { get; set; }
        public string? Currency { get; set; }

        public int UserBasketId { get; set; }
        public ICollection<int>? BookIds { get; set; }
        public ICollection<BookModelResponse>? Books { get; set; }

    }
}
