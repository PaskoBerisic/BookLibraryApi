using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.Users
{
    public class UserWithOrdersWithBooksSpecification : BaseSpecification<User>
    {
        public UserWithOrdersWithBooksSpecification() : base()
        {

            AddInclude(x => x.Include(y => y.Orders).ThenInclude(y => y.Books));
            
        }
    }
}
