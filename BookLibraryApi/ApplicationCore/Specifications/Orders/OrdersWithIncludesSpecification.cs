using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.Orders
{
    public class OrdersWithIncludesSpecification : BaseSpecification<Order>
    {
        public OrdersWithIncludesSpecification() : base()
        {
            AddInclude(x => x.Include(x => x.BookOrders).ThenInclude(x => x.Book));
            AddInclude(x => x.Include(x => x.User));
        }
    }
}
