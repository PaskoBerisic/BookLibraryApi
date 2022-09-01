using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.Genres
{
    public class GenresWithIncludesSpecification : BaseSpecification<Genre>
    {
        public GenresWithIncludesSpecification() : base()
        {
            AddInclude(x => x.Include(x => x.BookGenres).ThenInclude(x => x.Book));
        }
    }
}
