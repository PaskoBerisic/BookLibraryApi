using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.UserBaskets
{
    public class UserBasketByIdWithIncludesSpecification : BaseSpecification<UserBasket>
    {
        public UserBasketByIdWithIncludesSpecification(int id) : base()
        {
            SetCriteria(x => x.Id == id);
            AddInclude(x => x.Include(x => x.BookUserBaskets).ThenInclude(x => x.Book));
        }
    }
}
