using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.Users
{
    public class UsersForSpecification : BaseSpecification<User>
    {
        public UsersForSpecification(ICollection<int> usersIds) : base(x => usersIds.Contains(x.Id))
        {

        }
    }
}
