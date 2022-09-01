using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.Authors
{
    public class AuthorsWithIncludesSpecification : BaseSpecification<Author>
    {
        public AuthorsWithIncludesSpecification() : base()
        {
            AddInclude(x => x.Include(x => x.Country));
            AddInclude(x => x.Include(x => x.BookAuthors).ThenInclude(x => x.Book));
        }
    }
}
