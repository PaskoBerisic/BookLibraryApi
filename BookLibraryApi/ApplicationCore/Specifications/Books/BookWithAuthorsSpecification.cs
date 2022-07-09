using ApplicationCore.Entities;

namespace ApplicationCore.Specifications.Books
{
    public class BookWithAuthorsSpecification : BaseSpecification<Book>
    {
        public BookWithAuthorsSpecification() : base()
        {
            AddInclude(x => x.Authors);
            AddInclude(x => x.Genres);
        }
    }
}
