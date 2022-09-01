using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Authors;
using ApplicationCore.Specifications.Books;
using ApplicationCore.Specifications.Genres;
using ApplicationCore.Specifications.Orders;
using System.Linq;
using System.Linq.Expressions;

namespace ApplicationCore.Services
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> bookRepository;
        private readonly IRepository<Author> authorRepository;
        private readonly IRepository<Genre> genreRepository;
        private readonly IRepository<Order> orderRepository;

        public BookService(IRepository<Book> bookRepository, IRepository<Author> authorRepository, IRepository<Genre> genreRepository, IRepository<Order> orderRepository)
        {
            this.bookRepository = bookRepository;
            this.authorRepository = authorRepository;
            this.genreRepository = genreRepository;
            this.orderRepository = orderRepository;
        }
        public async Task GetAuthors(Book book)
        {
            var specification = new AuthorsForBookSpecification(book.Authors.Select(x => x.Id).ToList());
            var bookAuthors = (await authorRepository.FindWithSpecificationPattern(specification)).ToList();
            bookAuthors.AddRange(book.Authors.Where(x => !bookAuthors.Select(x => x.Id).Contains(x.Id)));
            book.Authors = bookAuthors;
        }
        public async Task GetGenres(Book book)
        {
            var specification = new GenresForBooksSpecification(book.Genres.Select(x => x.Id).ToList());
            var bookGenres = (await genreRepository.FindWithSpecificationPattern(specification)).ToList();
            bookGenres.AddRange(book.Genres.Where(x => !bookGenres.Select(x => x.Id).Contains(x.Id)));
            book.Genres = bookGenres;
        }
        public async Task GetOrders(Book book)
        {
            var specification = new OrdersForSpecification(book.Orders.Select(x => x.Id).ToList());
            var bookOrders = (await orderRepository.FindWithSpecificationPattern(specification)).ToList();
            bookOrders.AddRange(book.Orders.Where(x => !bookOrders.Select(x => x.Id).Contains(x.Id)));
            book.Orders = bookOrders;
        }

        public async Task<IEnumerable<Book>> GetAllWith()
        {
            var books = await bookRepository.GetAllWithIncludesAsync(new List<Expression<Func<Book, object>>>() { x => x.Authors, x => x.Genres, x => x.Orders, x => x.Publisher, x => x.Language });
            return books;
        }

        public async Task<IEnumerable<Book>> GetAllWithSpec()
        {
            var specification = new BooksWithIncludesSpecification();
            return await bookRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<Book> GetById(int id)
        {
            return await bookRepository.GetByIdAsync(id);
        }
        public async Task<Book> Add(Book book)
        {
            await GetAuthors(book);
            await GetGenres(book);
            await GetOrders(book);
            return await bookRepository.AddAsync(book);
        }

        public async Task Update(Book book)
        {
            await GetAuthors(book);
            await GetGenres(book);
            await bookRepository.UpdateAsync(book);
        }
        public async Task Delete(Book book)
        {
            await bookRepository.DeleteAsync(book);
        }
        public async Task DeleteById(int id)
        {
            await bookRepository.DeleteByIdAsync(id);
        }

        //public async Task<IEnumerable<Book>> FindWithSpecificationPattern(ISpecification<Book> specification = null)
        //{
        //    return await bookRepository.GetAllWithSpecAsync(specification);
        //}

        public async Task<IEnumerable<Book>> FindWithSpecificationPattern(ISpecification<Book> specification)
        {
            return await bookRepository.FindWithSpecificationPattern(specification);
        }
    }
}

