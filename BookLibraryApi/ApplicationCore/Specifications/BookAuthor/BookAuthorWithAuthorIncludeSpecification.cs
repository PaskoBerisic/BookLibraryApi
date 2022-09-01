using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.BookAuthors
{
    public class BookAuthorWithAuthorIncludeSpecification : BaseSpecification<BookAuthor>
    {
        public BookAuthorWithAuthorIncludeSpecification(int bookId) : base()
        {
            SetCriteria(x => x.BookId == bookId);
            AddInclude(x => x.Include(x => x.Author));
        }
    }
}
