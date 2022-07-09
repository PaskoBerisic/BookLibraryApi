using System;

namespace ApplicationCore.Entities
{
    public class BookRental
    {
        public int Id { get; set; }
        public DateTime RentedFromDate { get; set; }
        public DateTime RentedToDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public string? Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime Updated { get; set; }
        // One to Many
        //public int UserId { get; set; }
        //public User? User { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }

    }
}
