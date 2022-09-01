using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.BookAuthors
{
    public class BookAuthorWithBookIncludeSpecification : BaseSpecification<BookAuthor>
    {
        public BookAuthorWithBookIncludeSpecification(int authorId) : base()
        {
            SetCriteria(x => x.AuthorId == authorId);
            AddInclude(x => x.Include(x => x.Book));
        }
    }
}
