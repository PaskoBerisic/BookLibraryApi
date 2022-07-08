using ApplicationCore.Enums;

namespace BookLibraryApi.Models.User
{
    public class UserModelShort
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Role Role { get; set; }

    }
}
