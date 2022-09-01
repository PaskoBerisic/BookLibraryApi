using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.BookUserBaskets
{
    public class BookUserBasketSpecification : BaseSpecification<BookUserBasket>
    {
        public BookUserBasketSpecification(int userBasketId) : base()
        {
            SetCriteria(x => x.UserBasketId == userBasketId);
            AddInclude(x => x.Include(x => x.Book));
        }
    }
}
