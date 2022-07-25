using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.Orders
{
    public class OrdersWithIncludesSpecification : BaseSpecification<Order>
    {
        public OrdersWithIncludesSpecification() : base()
        {
            AddInclude(x => x.Include(x => x.Books));
            AddInclude(x => x.Include(x => x.User));
        }
    }
}
