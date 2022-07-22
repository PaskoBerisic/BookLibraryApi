using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.Books
{
    public class BooksWithIncludesSpecification : BaseSpecification<Book>
    {
        public BooksWithIncludesSpecification() : base()
        {
            AddInclude(x => x.Include(x => x.Authors));
            AddInclude(x => x.Include(x => x.Genres));
            AddInclude(x => x.Include(x => x.Orders));

        }
    }
}
