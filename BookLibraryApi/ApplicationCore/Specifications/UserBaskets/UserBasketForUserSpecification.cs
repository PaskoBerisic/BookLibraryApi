using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.UserBaskets
{
    public class UserBasketForUserSpecification : BaseSpecification<UserBasket>
    {
        public UserBasketForUserSpecification(int id) : base()
        {
            SetCriteria(x => x.Id == id);
            AddInclude(x => x.Include(x => x.BookUserBaskets).ThenInclude(x => x.Book));
        }
    }
}
