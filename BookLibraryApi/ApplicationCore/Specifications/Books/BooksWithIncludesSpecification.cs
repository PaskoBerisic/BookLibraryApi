using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.Books
{
    public class BooksWithIncludesSpecification : BaseSpecification<Book>
    {
        public BooksWithIncludesSpecification() : base()
        {
            AddInclude(x => x.Include(x => x.BookAuthors).ThenInclude(x => x.Author));
            AddInclude(x => x.Include(x => x.BookGenres).ThenInclude(x => x.Genre));
            AddInclude(x => x.Include(x => x.BookOrders).ThenInclude(x => x.Order));
            AddInclude(x => x.Include(x => x.Publisher));
            AddInclude(x => x.Include(x => x.Language));
        }
    }
}
