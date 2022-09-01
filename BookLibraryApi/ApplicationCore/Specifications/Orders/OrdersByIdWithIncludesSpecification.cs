using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.Orders
{
    public class OrdersByIdWithIncludesSpecification : BaseSpecification<Order>
    {
        public OrdersByIdWithIncludesSpecification(int id) : base()
        {
            SetCriteria(x => x.Id == id);
            AddInclude(x => x.Include(x => x.BookOrders).ThenInclude(x => x.Book));
            AddInclude(x => x.Include(x => x.User));
        }
    }
}
