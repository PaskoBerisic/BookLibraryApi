using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Options
{
    public class AuthSettingsJWT
    {
        public string? Secret { get; set; }
        public string? Public { get; set; }
    }
}
