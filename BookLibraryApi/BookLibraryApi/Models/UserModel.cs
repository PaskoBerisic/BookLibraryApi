using ApplicationCore.Entities;
using ApplicationCore.Enums;

namespace BookLibraryWebAPI.Models
{
    public class UserModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Adress { get; set; }
        public Role Role { get; set; }
        public ICollection<Order>? Orders { get; set; }

    }
}
