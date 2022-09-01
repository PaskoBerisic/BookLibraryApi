using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.BookOrders
{
    public class BookOrderSpecification : BaseSpecification<BookOrder>
    {
        public BookOrderSpecification(int orderId) : base()
        {
            SetCriteria(x => x.OrderId == orderId);
            AddInclude(x => x.Include(x => x.Book));
        }
    }
}
