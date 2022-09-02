namespace BookLibraryApi.Models.UserBasket
{
    public class UserBasketModelRequest
    {
        public int Id { get; set; }
        public decimal TotalRentalPrice { get; set; }
        public decimal TotalRentalPriceWithVAT { get; set; }
        public string? Currency { get; set; }

        public int UserId { get; set; }
        public ICollection<int>? BookIds { get; set; }
    }
}
