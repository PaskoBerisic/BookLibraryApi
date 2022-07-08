namespace BookLibraryApi.Models.Order
{
    public class OrderModelRequest
    {
        public int Id { get; set; }
        public UserModel User { get; set; }
        public ICollection<BookModel> Books { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalRentalPrice { get; set; }
        public decimal TotalRentalPriceWithVAT { get; set; }
        public string? Currency { get; set; }
    }
}
