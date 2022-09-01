using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.Users
{
    public class UserByIdWithIncludesSpecification : BaseSpecification<User>
    {
        public UserByIdWithIncludesSpecification(int id) : base()
        {
            SetCriteria(x => x.Id == id);
            AddInclude(x => x.Include(x => x.UserBasket));
            AddInclude(x => x.Include(x => x.UserBasket).ThenInclude(y => y.BookUserBaskets).ThenInclude(z => z.Book));
        }
    }
}
