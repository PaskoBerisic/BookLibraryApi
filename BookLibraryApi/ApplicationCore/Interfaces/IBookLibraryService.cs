using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IBookLibraryService
    {
        //Book
        Task<IEnumerable<Book>> GetAllBooks();
        Task<IEnumerable<Book>> GetAllBooksWith();
        Task<IEnumerable<Book>> GetAllBooksWithAuthorsSpec(ISpecification<Book> specification);

        Task<Book> GetBookById(int id);
        Task<Book> GetBookByName(string name);
        Task<Book> AddBook(Book book);
        Task UpdateBook(Book book);
        Task DeleteBook(Book book);
        Task DeleteBookById(int id);

        //Author
        Task<IEnumerable<Author>> GetAllAuthors();
        Task<IEnumerable<Author>> GetAllAuthorsWith();

        Task<Author> GetAuthorById(int id);
        Task<Author> GetAuthorByName(string name);
        Task<Author> AddAuthor(Author author);
        Task UpdateAuthor(Author author);
        Task DeleteAuthor(Author author);
        Task DeleteAuthorById(int id);

        //Order
        Task<IEnumerable<Order>> GetAllOrders();
        Task<IEnumerable<Order>> GetAllOrdersWith();

        Task<Order> GetOrderById(int id);
        Task<Order> GetOrderByName(string name);
        Task<Order> AddOrder(Order order);
        Task UpdateOrder(Order order);
        Task DeleteOrder(Order order);
        Task DeleteOrderById(int id);

        //Admin
        //Country
        Task<IEnumerable<Country>> GetAllCountires();
        Task<Country> GetCountryById(int id);
        Task<Country> AddCountry(Country country);
        Task UpdateCountry(Country country);
        Task DeleteCountryById(int id);

        //Genre
        Task<IEnumerable<Genre>> GetAllGenresWith();
        Task<Genre> GetGenreById(int id);
        Task<Genre> AddGenre(Genre genre);
        Task UpdateGenre(Genre genre);
        Task DeleteGenreById(int id);

        //Language
        Task<IEnumerable<Language>> GetAllLanguagesWith();
        Task<Language> GetLanguageById(int id);
        Task<Language> AddLanguage(Language language);
        Task UpdateLanguage(Language language);
        Task DeleteLanguageById(int id);

        //Publisher
        Task<IEnumerable<Publisher>> GetAllPublishersWith();
        Task<Publisher> GetPublisherById(int id);
        Task<Publisher> AddPublisher(Publisher publisher);
        Task UpdatePublisher(Publisher publisher);
        Task DeletePublisherById(int id);
    }
}
