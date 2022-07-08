using ApplicationCore.Enums;

namespace BookLibraryApi.Models.User
{
    public class UserModelRequest
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Adress { get; set; }
        public Role Role { get; set; }
        public ICollection<OrderModel>? Orders { get; set; }
    }
}
