using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.Authors
{
    public class AuthorByIdWithIncludesSpecification : BaseSpecification<Author>
    {
        public AuthorByIdWithIncludesSpecification(int id) : base() 
        {
            SetCriteria(x => x.Id == id);
            AddInclude(x => x.Include(x => x.Country));
            AddInclude(x => x.Include(x => x.BookAuthors).ThenInclude(y => y.Book));
        }
    }
}
