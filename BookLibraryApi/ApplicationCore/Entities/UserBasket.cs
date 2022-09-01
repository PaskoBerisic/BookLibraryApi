namespace ApplicationCore.Entities
{
    public class UserBasket
    {
        public int Id { get; set; }
        public decimal TotalRentalPrice { get; set; }
        public decimal TotalRentalPriceWithVAT { get; set; }
        public string? Currency { get; set; }
       
        // Many to Many
        public ICollection<BookUserBasket>? BookUserBaskets { get; set; }
    }
}
