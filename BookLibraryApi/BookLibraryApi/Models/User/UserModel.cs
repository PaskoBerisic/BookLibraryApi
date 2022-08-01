using ApplicationCore.Entities;
using ApplicationCore.Enums;
using BookLibraryApi.Models.Order;

namespace BookLibraryApi.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
        public Role Role { get; set; }
        // One to Many
        public UserBasketModel? UserBasket { get; set; }
        //Many to Many
        public ICollection<OrderModel>? Orders { get; set; }
    }
}
