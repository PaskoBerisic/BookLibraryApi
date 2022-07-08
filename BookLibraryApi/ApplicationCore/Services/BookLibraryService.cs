using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class BookLibraryService : IBookLibraryService
    {
        private readonly IRepository<Book> bookRepository;
        private readonly IRepository<Author> authorRepository;
        private readonly IRepository<Order> orderRepository;
        private readonly IRepository<Country> countryRepository;
        private readonly IRepository<Genre> genreRepository;
        private readonly IRepository<Language> languageRepository;
        private readonly IRepository<Publisher> publisherRepository;


        public BookLibraryService(
            IRepository<Book> bookRepository,
            IRepository<Author> authorRepository,
            IRepository<Order> orderRepository,
            IRepository<Country> countryRepository,
            IRepository<Genre> genreRepository,
            IRepository<Language> languageRepository,
            IRepository<Publisher> publisherRepository
            )
        {
            this.bookRepository = bookRepository;
            this.authorRepository = authorRepository; 
            this.orderRepository = orderRepository;
            this.countryRepository = countryRepository;
            this.genreRepository = genreRepository;
            this.languageRepository = languageRepository;
            this.publisherRepository = publisherRepository;
        }

        //Book
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await bookRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Book>> GetAllBooksWith()
        {
            return await bookRepository.GetAllWithIncludesAsync(new List<Expression<Func<Book, object>>>() { x => x.Authors, x => x.Genres, x => x.Publisher, x => x.Language });
        }

        public async Task<IEnumerable<Book>> GetAllBooksWithAuthorsSpec(ISpecification<Book> specification)
        {
            var books = await bookRepository.GetAllWithSpecAsync(specification);
            return books;
        }
        public async Task<Book> GetBookById(int id)
        {
            return await bookRepository.GetByIdAsync(id);
        }
        public async Task<Book> GetBookByName(string name)
        {
            return await bookRepository.GetByNameAsync(name);
        }
        public async Task<Book> AddBook(Book book)
        {
            return await bookRepository.AddAsync(book);
        }
        public async Task UpdateBook(Book book)
        {
            await bookRepository.UpdateAsync(book);
        }
        public async Task DeleteBook(Book book)
        {
            await bookRepository.DeleteAsync(book);
        }
        public async Task DeleteBookById(int id)
        {
            await bookRepository.DeleteByIdAsync(id);
        }

        //Author
        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await authorRepository.GetAllAsync();
        }
        public async Task<IEnumerable<Author>> GetAllAuthorsWith()
        {
            return await authorRepository.GetAllWithIncludesAsync(new List<Expression<Func<Author, object>>>() { x => x.Books, y => y.Country});
        }

        public async Task<Author> GetAuthorById(int id)
        {
            return await authorRepository.GetByIdAsync(id);
        }
        public async Task<Author> GetAuthorByName(string name)
        {
            return await authorRepository.GetByNameAsync(name);
        }
        public async Task<Author> AddAuthor(Author author)
        {
            return await authorRepository.AddAsync(author);
        }
        public async Task UpdateAuthor(Author author)
        {
            await authorRepository.UpdateAsync(author);
        }
        public async Task DeleteAuthor(Author author)
        {
            await authorRepository.DeleteAsync(author);
        }
        public async Task DeleteAuthorById(int id)
        {
            await authorRepository.DeleteByIdAsync(id);
        }

        //Order
        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await orderRepository.GetAllAsync();
        }
        public async Task<IEnumerable<Order>> GetAllOrdersWith()
        {
            return await orderRepository.GetAllWithIncludesAsync(new List<Expression<Func<Order, object>>>() { x => x.User, y => y.Books });
        }
        public async Task<Order> GetOrderById(int id)
        {
            return await orderRepository.GetByIdAsync(id);
        }
        public async Task<Order> GetOrderByName(string name)
        {
            return await orderRepository.GetByNameAsync(name);
        }
        public async Task<Order> AddOrder(Order order)
        {
            return await orderRepository.AddAsync(order);
        }
        public async Task UpdateOrder(Order order)
        {
            await orderRepository.UpdateAsync(order);
        }
        public async Task DeleteOrder(Order order)
        {
            await orderRepository.DeleteAsync(order);
        }
        public async Task DeleteOrderById(int id)
        {
            await orderRepository.DeleteByIdAsync(id);
        }

        //Admin
        //Country
        public async Task<IEnumerable<Country>> GetAllCountires()
        {
            return await countryRepository.GetAllAsync();
        }
        public async Task<Country> GetCountryById(int id)
        {
            return await countryRepository.GetByIdAsync(id);
        }
        public async Task<Country> AddCountry(Country country)
        {
            return await countryRepository.AddAsync(country);
        }
        public async Task UpdateCountry(Country country)
        {
            await countryRepository.UpdateAsync(country);
        }
        public async Task DeleteCountryById(int id)
        {
            await countryRepository.DeleteByIdAsync(id);
        }

        //Genre
        public async Task<IEnumerable<Genre>> GetAllGenresWith()
        {
            return await genreRepository.GetAllWithIncludesAsync(new List<Expression<Func<Genre, object>>>() { x => x.Books });
        }
        public async Task<Genre> GetGenreById(int id)
        {
            return await genreRepository.GetByIdAsync(id);
        }
        public async Task<Genre> AddGenre(Genre genre)
        {
            return await genreRepository.AddAsync(genre);
        }
        public async Task UpdateGenre(Genre genre)
        {
            await genreRepository.UpdateAsync(genre);
        }
        public async Task DeleteGenreById(int id)
        {
            await genreRepository.DeleteByIdAsync(id);
        }
        //Language
        public async Task<IEnumerable<Language>> GetAllLanguagesWith()
        {
            return await languageRepository.GetAllWithIncludesAsync(new List<Expression<Func<Language, object>>>() { x => x.Books});
        }
        public async Task<Language> GetLanguageById(int id)
        {
            return await languageRepository.GetByIdAsync(id);
        }
        public async Task<Language> AddLanguage(Language language)
        {
            return await languageRepository.AddAsync(language);
        }
        public async Task UpdateLanguage(Language language)
        {
            await languageRepository.UpdateAsync(language);
        }
        public async Task DeleteLanguageById(int id)
        {
            await languageRepository.DeleteByIdAsync(id);
        }

        //Publisher
        public async Task<IEnumerable<Publisher>> GetAllPublishersWith()
        {
            return await publisherRepository.GetAllWithIncludesAsync(new List<Expression<Func<Publisher, object>>>() { x => x.Books });
        }
        public async Task<Publisher> GetPublisherById(int id)
        {
            return await publisherRepository.GetByIdAsync(id);
        }
        public async Task<Publisher> AddPublisher(Publisher publisher)
        {
            return await publisherRepository.AddAsync(publisher);
        }
        public async Task UpdatePublisher(Publisher publisher)
        {
            await publisherRepository.UpdateAsync(publisher);
        }
        public async Task DeletePublisherById(int id)
        {
            await publisherRepository.DeleteByIdAsync(id);
        }
    }
}
