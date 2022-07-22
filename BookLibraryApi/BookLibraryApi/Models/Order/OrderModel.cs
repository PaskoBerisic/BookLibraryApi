using ApplicationCore.Entities;
using BookLibraryApi.Models.Book;
using BookLibraryApi.Models.User;
using System.Collections.Generic;

namespace BookLibraryApi.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalRentalPrice { get; set; }
        public decimal TotalRentalPriceWithVAT { get; set; }
        public string? Currency { get; set; }
        public UserModel? User { get; set; }
        public ICollection<BookModel>? Books { get; set; }

    }
}
