using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Authentication
{
    public class AuthenticateRequestJWT
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
