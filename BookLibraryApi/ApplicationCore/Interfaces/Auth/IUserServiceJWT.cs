using ApplicationCore.Authentication;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces.Auth
{
    public interface IUserServiceJWT
    {
        Task<AuthenticateResponseJWT> Authenticate(AuthenticateRequestJWT authenticateRequest);
        Task<User> GetById(int id);
    }
}
