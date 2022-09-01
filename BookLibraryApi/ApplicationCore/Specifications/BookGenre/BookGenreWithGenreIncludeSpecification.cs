using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.BookGenres
{
    public class BookGenreWithGenreIncludeSpecification : BaseSpecification<BookGenre>
    {
        public BookGenreWithGenreIncludeSpecification(int bookId)
        {
            SetCriteria(x => x.BookId == bookId);
            AddInclude(x => x.Include(x => x.Genre));
        }
    }
}
