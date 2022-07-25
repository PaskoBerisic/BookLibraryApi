using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.UserBaskets
{
    public class UserBasketsWithSpecificationIncludes : BaseSpecification<UserBasket>
    {
        public UserBasketsWithSpecificationIncludes() : base()
        {
            AddInclude(x => x.Include(x => x.User)); 
            AddInclude(x => x.Include(x => x.Books));
        }
    }
}
