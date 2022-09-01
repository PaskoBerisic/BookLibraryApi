using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Orders;
using ApplicationCore.Specifications.Users;

namespace ApplicationCore.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;
        private readonly IRepository<Order> orderRepository;
        private readonly IRepository<UserBasket> userBasketRepository;

        public UserService(IRepository<User> userRepository, IRepository<Order> orderRepository, IRepository<UserBasket> userBasketRepository)
        {
            this.userRepository = userRepository;
            this.orderRepository = orderRepository;
            this.userBasketRepository = userBasketRepository;
        }

        public async Task<IEnumerable<User>> GetAllWithSpec()
        {
            var specification = new UsersWithIncludesSpecification();
            return await userRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<User> GetById(int id)
        {
            var specification = new UserByIdWithIncludesSpecification(id);
            return await userRepository.GetSingleWithSpecAsync(specification);
        }

        public async Task<User> GetByUsername(string username)
        {
            var specification = new UsersByUsernameSpecification(username);
            return await userRepository.GetSingleWithSpecAsync(specification);
        }

        public async Task<User> Add(User user)
        {
            var userBasket = await userBasketRepository.AddAsync(new UserBasket { Id = 0, Currency = "HRK" });
            user.UserBasket = userBasket;
            user.PasswordCrypted = BCrypt.Net.BCrypt.HashPassword(user.Password);
            return await userRepository.AddAsync(user);
        }

        public async Task Update(User user)
        {
            await userRepository.UpdateAsync(user);
        }

        public async Task Delete(int id)
        {
            await userRepository.DeleteByIdAsync(id);
        }

        public async Task DeleteById(int id)
        {
            await userRepository.DeleteByIdAsync(id);
        }

        public async Task<IEnumerable<Order>> FindOrders(User user)
        {
            var specification = new OrdersByIdWithIncludesSpecification(user.Id);
            return await orderRepository.FindWithSpecificationAsync(specification);
        }

        public async Task<IEnumerable<User>> FindWithSpecification(ISpecification<User> specification)
        {
            return await userRepository.FindWithSpecificationAsync(specification);
        }
    }
}
