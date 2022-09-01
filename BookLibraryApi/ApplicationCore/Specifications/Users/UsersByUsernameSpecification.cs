using ApplicationCore.Entities;

namespace ApplicationCore.Specifications.Users
{
    public class UsersByUsernameSpecification : BaseSpecification<User>
    {
        public UsersByUsernameSpecification(string username) : base(x => x.Username == username)
        {

        }
    }
}
