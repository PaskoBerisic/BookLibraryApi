using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.NewFolder
{
    public class OrdersForSpecification : BaseSpecification<Order>
    {
        public OrdersForSpecification(ICollection<int> ordersIds) : base(x => ordersIds.Contains(x.Id))
        {

        }
    }
}
