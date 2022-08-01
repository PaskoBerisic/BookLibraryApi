using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface ITokenServiceJWT
    {
        string GenerateToken(User user);
        int? ValidateToken(string token);
    }
}
