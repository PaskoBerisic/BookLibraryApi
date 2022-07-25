using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.NewFolder;
using ApplicationCore.Specifications.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;
        private readonly IRepository<Order> orderRepository;

        public UserService(IRepository<User> userRepository, IRepository<Order> orderRepository)
        {
            this.userRepository = userRepository;
            this.orderRepository = orderRepository;
        }
        public async Task GetOrders(User user)
        {
            var specification = new OrdersForSpecification(user.Orders.Select(x => x.Id).ToList());
            var userOrders = (await orderRepository.FindWithSpecificationPattern(specification)).ToList();
            userOrders.AddRange(user.Orders.Where(x => !userOrders.Select(x => x.Id).Contains(x.Id)));
            user.Orders = userOrders;
        }
        //public async Task<IEnumerable<User>> GetAll()
        //{
        //    var specification = new UserWithOrdersWithBooksSpecification();
        //    return await userRepository.GetAllWithSpecAsync(specification);
        //}

        public async Task<IEnumerable<User>> GetAllWith()
        {
            var users = await userRepository.GetAllWithIncludesAsync(new List<Expression<Func<User, object>>>() { x => x.Orders });
            return users;
        }

        public async Task<IEnumerable<User>> GetAllWithSpec(ISpecification<User> specification)
        {
            return await userRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<User> GetById(int id)
        {
            return await userRepository.GetByIdAsync(id);
        }
        public async Task<User> Add(User user)
        {
            await GetOrders(user);
            return await userRepository.AddAsync(user);
        }
        public async Task Update(User user)
        {
            await GetOrders(user);
            await userRepository.UpdateAsync(user);
        }
        public async Task Delete(User user)
        {
            await userRepository.DeleteAsync(user);
        }
        public async Task DeleteById(int id)
        {
            await userRepository.DeleteByIdAsync(id);
        }
    }
}
