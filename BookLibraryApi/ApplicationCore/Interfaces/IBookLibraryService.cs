using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IBookLibraryService
    {
        //Book
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookById(int id);
        Task<Book> GetBookByName(string name);
        Task<Book> AddBook(Book book);
        Task UpdateBook(Book book);
        Task DeleteBook(Book book);
        Task DeleteBookById(int id);

        //Author
        Task<IEnumerable<Author>> GetAllAuthors();
        Task<Author> GetAuthorById(int id);
        Task<Author> GetAuthorByName(string name);
        Task<Author> AddAuthor(Author author);
        Task UpdateAuthor(Author author);
        Task DeleteAuthor(Author author);
        Task DeleteAuthorById(int id);

        //Order
        Task<IEnumerable<Order>> GetAllOrders();
        Task<Order> GetOrderById(int id);
        Task<Order> GetOrderByName(string name);
        Task<Order> AddOrder(Order order);
        Task UpdateOrder(Order order);
        Task DeleteOrder(Order order);
        Task DeleteOrderById(int id);
    }
}
