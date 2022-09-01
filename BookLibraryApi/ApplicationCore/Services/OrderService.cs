using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Orders;

namespace ApplicationCore.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> orderRepository;
        private readonly IRepository<BookOrder> bookOrderRepository;

        public OrderService(IRepository<Order> orderRepository, IRepository<BookOrder> bookOrderRepository)
        {
            this.orderRepository = orderRepository;
            this.bookOrderRepository = bookOrderRepository;
        }

        public async Task<IEnumerable<Order>> GetAllWithSpec()
        {
            var specification = new OrdersWithIncludesSpecification();
            return await orderRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<Order> GetById(int id)
        {
            var specification = new OrdersByIdWithIncludesSpecification(id);
            return await orderRepository.GetSingleWithSpecAsync(specification);
        }

        public async Task<Order> Add(Order order, ICollection<int> bookIds)
        {
            await orderRepository.AddAsync(order);

            foreach (var bookId in bookIds)
            {
                await bookOrderRepository.AddAsync(new BookOrder { BookId = bookId, OrderId = order.Id });
            }

            return order;
        }

        public async Task Update(Order order, ICollection<int> bookIds)
        {
            await orderRepository.UpdateAsync(order);
            var bookOrders = await GetBookOrders(order.Id);

            var bookIdsToDelete = bookOrders.Select(x => x.BookId).Except(bookIds);
            var bookIdsToAdd = bookIds.Except(bookOrders.Select(x => x.BookId));


            // delete books
            foreach (var book in bookOrders.Where(x => bookIdsToDelete.Contains(x.BookId)))
            {
                await bookOrderRepository.DeleteAsync(book);
            }


            // add books
            foreach (var bookId in bookIdsToAdd)
            {
                await bookOrderRepository.AddAsync(new BookOrder { BookId = bookId, OrderId = order.Id });
            }

        }

        public async Task Delete(Order order)
        {
            await orderRepository.DeleteAsync(order);
        }

        public async Task DeleteById(int id)
        {
            await orderRepository.DeleteByIdAsync(id);
        }

        public async Task<IEnumerable<Order>> FindOrdersForUser(int id)
        {
            var specification = new OrdersByUserIdWithIncludesSpecification(id);
            return await orderRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<IEnumerable<Order>> FindWithSpecification(ISpecification<Order> specification)
        {
            return await orderRepository.FindWithSpecificationAsync(specification);
        }

        public async Task<IEnumerable<BookOrder>> GetBookOrders(int orderId)
        {
            var bookOrderSpec = new BookOrderSpecification(orderId);
            var bookOrders = await bookOrderRepository.GetAllWithSpecAsync(bookOrderSpec);

            return bookOrders;
        }
    }
}
