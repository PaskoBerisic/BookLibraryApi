using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class UserBasket
    {
        public int Id { get; set; }
        public decimal TotalRentalPrice { get; set; }
        public decimal TotalRentalPriceWithVAT { get; set; }
        public string? Currency { get; set; }
        // One to Many
       
        // Many to Many
        public ICollection<Book>? Books { get; set; }

    }
}
