using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces.Auth
{
    public interface IUserServiceAuth
    {
        Task<User> Authenticate(string username, string password);
    }
}
