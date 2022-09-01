using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.Users
{
    public class UsersWithIncludesSpecification : BaseSpecification<User>
    {
        public UsersWithIncludesSpecification() : base()
        {
            AddInclude(x => x.Include(x => x.UserBasket));
            AddInclude(x => x.Include(x => x.UserBasket).ThenInclude(y => y.BookUserBaskets).ThenInclude(z => z.Book));
        }
    }
}
