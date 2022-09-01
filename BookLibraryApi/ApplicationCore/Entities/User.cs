using ApplicationCore.Enums;

namespace ApplicationCore.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? PasswordCrypted { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
        public Role Role { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime Updated { get; set; }

        // One to Many
        public int? UserBasketId { get; set; }
        public UserBasket? UserBasket { get; set; }
    }
}
