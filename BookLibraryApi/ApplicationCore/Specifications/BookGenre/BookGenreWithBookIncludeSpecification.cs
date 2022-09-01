using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.BookGenres
{
    public class BookGenreWithBookIncludeSpecification : BaseSpecification<BookGenre>
    {
        public BookGenreWithBookIncludeSpecification(int genreId) : base()
        {
            SetCriteria(x => x.GenreId == genreId);
            AddInclude(x => x.Include(x => x.Book));
        }
    }
}
