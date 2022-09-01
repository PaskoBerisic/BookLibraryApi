using ApplicationCore.Entities;

namespace ApplicationCore.Specifications.BookUserBaskets
{
    public class BookUserBasketByBookIdSpecification : BaseSpecification<BookUserBasket>
    {
        public BookUserBasketByBookIdSpecification(int bookId, int userBasketId) : base()
        {
            SetCriteria(x => x.UserBasketId == userBasketId && x.BookId == bookId);
        }
    }
}
