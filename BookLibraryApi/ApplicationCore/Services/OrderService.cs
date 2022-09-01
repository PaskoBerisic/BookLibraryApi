using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Books;
using ApplicationCore.Specifications.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> orderRepository;
        private readonly IRepository<Book> bookRepository;

        public OrderService(IRepository<Order> orderRepository, IRepository<Book> bookRepository)
        {
            this.orderRepository = orderRepository;
            this.bookRepository = bookRepository;
        }
        public async Task GetBooks(Order order)
        {
            var specification = new BooksForSpecification(order.Books.Select(x => x.Id).ToList());
            var orderBooks = (await bookRepository.FindWithSpecificationPattern(specification)).ToList();
            orderBooks.AddRange(order.Books.Where(x => !orderBooks.Select(x => x.Id).Contains(x.Id)));
            order.Books = orderBooks;
        }

        public async Task<IEnumerable<Order>> GetAllWith()
        {
           return await orderRepository.GetAllWithIncludesAsync(new List<Expression<Func<Order, object>>>() { x => x.User, x => x.Books });
        }

        public async Task<IEnumerable<Order>> GetAllWithSpec()
        {
            var specification = new OrdersWithIncludesSpecification();
            return await orderRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<Order> GetById(int id)
        {
            return await orderRepository.GetByIdAsync(id);
        }
        public async Task<Order> Add(Order order)
        {
            await GetBooks(order);
            IncrementBooks(order);
            return await orderRepository.AddAsync(order);
        }

        public async Task Update(Order order)
        {
            await GetBooks(order);
            await orderRepository.UpdateAsync(order);
        }
        public async Task Delete(Order order)
        {
            await orderRepository.DeleteAsync(order);
        }
        public async Task DeleteById(int id)
        {
            await orderRepository.DeleteByIdAsync(id);
        }
        public void IncrementBooks(Order order)
        {
            var books = bookRepository.GetAllAsync();
            foreach(var book in order.Books)
            {
                var incrementBook = bookRepository.GetByIdAsync(book.Id);
                
            }
        }
    }
}
