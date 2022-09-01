using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.Genres
{
    public class GenreByIdWithIncludesSpecification : BaseSpecification<Genre>
    {
        public GenreByIdWithIncludesSpecification(int id) : base()
        {
            SetCriteria(x => x.Id == id);
            AddInclude(x => x.Include(x => x.BookGenres).ThenInclude(x => x.Book));
        }
    }
}
