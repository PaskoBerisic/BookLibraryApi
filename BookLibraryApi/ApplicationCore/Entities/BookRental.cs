using System;

namespace ApplicationCore.Entities
{
    public class BookRental
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public ICollection<Book>? Book { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public DateTime RentedFromDate { get; set; }
        public DateTime RentedToDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public string? Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime Updated { get; set; }
    }
}
