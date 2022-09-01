using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.UserBaskets
{
    public class UserBasketsWithIncludesSpecification : BaseSpecification<UserBasket>
    {
        public UserBasketsWithIncludesSpecification() : base()
        {
            AddInclude(x => x.Include(x => x.BookUserBaskets).ThenInclude(x => x.Book));
        }
    }
}
