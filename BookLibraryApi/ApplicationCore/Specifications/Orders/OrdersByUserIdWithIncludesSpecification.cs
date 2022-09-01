using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.Orders
{
    public class OrdersByUserIdWithIncludesSpecification : BaseSpecification<Order>
    {
        public OrdersByUserIdWithIncludesSpecification(int userId) : base()
        {
            SetCriteria(x => x.UserId == userId);
            AddInclude(x => x.Include(x => x.BookOrders).ThenInclude(x => x.Book));
            AddInclude(x => x.Include(x => x.User));

        }
    }
}
