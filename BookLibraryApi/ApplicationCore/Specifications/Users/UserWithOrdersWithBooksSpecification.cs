using ApplicationCore.Entities;

namespace ApplicationCore.Specifications.Users
{
    public class UserWithOrdersWithBooksSpecification : BaseSpecification<User>
    {
        public UserWithOrdersWithBooksSpecification() : base()
        {

            //AddInclude(x => x.Include(y => y.Order).ThenInclude(y => y.Books));
            
        }
    }
}
