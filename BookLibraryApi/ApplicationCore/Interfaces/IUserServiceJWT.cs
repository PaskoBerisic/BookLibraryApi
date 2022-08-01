using ApplicationCore.Authentication;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IUserServiceJWT
    {
        Task<AuthenticateResponseJWT> Authenticate(AuthenticateRequestJWT authenticateRequest);
        Task<User> GetById(int id);
    }
}
