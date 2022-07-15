using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Books;
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
        private readonly IBookService bookService;
        public OrderService(IRepository<Order> orderRepository, IBookService bookService)
        {
            this.orderRepository = orderRepository;
            this.bookService = bookService;
        }
        public async Task GetBooks(Order order)
        {
            var specification = new BooksForSpecification(order.Books.Select(x => x.Id).ToList());
            var orderBooks = (await bookService.GetAllWithSpec(specification)).ToList();
            orderBooks.AddRange(order.Books.Where(x => !orderBooks.Select(x => x.Id).Contains(x.Id)));
            order.Books = orderBooks;
        }
        public async Task<IEnumerable<Order>> GetAll()
        {
            return await orderRepository.GetAllWithIncludesAsync(new List<Expression<Func<Order, object>>>() { x => x.User, x=> x.Books });
        }

        public async Task<IEnumerable<Order>> GetAllWith(ISpecification<Order> specification)
        {
            var orders = await orderRepository.GetAllWithSpecAsync(specification);
            return orders;
        }

        public async Task<IEnumerable<Order>> GetAllWithSpec(ISpecification<Order> specification)
        {
            return await orderRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<Order> GetById(int id)
        {
            return await orderRepository.GetByIdAsync(id);
        }
        public async Task<Order> Add(Order order)
        {
            await GetBooks(order);
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
    }
}
