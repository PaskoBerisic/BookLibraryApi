using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class UserBasket
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ICollection<Book>? Books { get; set; }
        public decimal TotalRentalPrice { get; set; }
        public decimal TotalRentalPriceWithVAT { get; set; }
        public string? Currency { get; set; }
    }
}
