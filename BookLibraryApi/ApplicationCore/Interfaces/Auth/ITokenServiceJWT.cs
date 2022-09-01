using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces.Auth
{
    public interface ITokenServiceJWT
    {
        string GenerateToken(User user);
        int? ValidateToken(string token);
    }
}
