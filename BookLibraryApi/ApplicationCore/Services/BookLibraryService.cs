using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class BookLibraryService : IBookLibraryService
    {
        private readonly IRepository<Book> bookRepository;
        private readonly IRepository<Author> authorRepository;
        private readonly IRepository<Order> orderRepository;

        public BookLibraryService(IRepository<Book> bookRepository, IRepository<Author> authorRepository, IRepository<Order> orderRepository )
        {
            this.bookRepository = bookRepository;
            this.authorRepository = authorRepository; 
            this.orderRepository = orderRepository;
        }

        //Book
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await bookRepository.GetAllAsync();
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

    }
}
