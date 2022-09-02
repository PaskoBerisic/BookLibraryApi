namespace BookLibraryApi.Models
{
    public class CheckoutModel
    {
        public int UserId { get; set; }
        public ICollection<int>? BookIds { get; set; }
        public decimal TotalRentalPrice { get; }
        public decimal TotalRentalPriceWithVAT { get; set; }
        public string? Currency { get; set; }
    }
}
