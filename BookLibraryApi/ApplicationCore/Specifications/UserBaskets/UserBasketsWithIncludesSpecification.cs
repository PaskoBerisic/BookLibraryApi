using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.UserBaskets
{
    public class UserBasketsWithIncludesSpecification : BaseSpecification<UserBasket>
    {
        public UserBasketsWithIncludesSpecification() : base()
        { 
            AddInclude(x => x.Include(x => x.Books));
        }
    }
}
