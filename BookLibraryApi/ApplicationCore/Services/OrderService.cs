using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
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
        public OrderService(IRepository<Order> orderRepository)
        {
            this.orderRepository = orderRepository;
        }
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
    }
}
