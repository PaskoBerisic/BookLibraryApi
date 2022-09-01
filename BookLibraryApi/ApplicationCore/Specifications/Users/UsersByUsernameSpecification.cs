using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.Users
{
    public class UsersByUsernameSpecification : BaseSpecification<User>
    {
        public UsersByUsernameSpecification(string username) : base(x => x.Username == username)
        {

        }
    }
}
