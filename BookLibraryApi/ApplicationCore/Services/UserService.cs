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
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;
        public UserService(IRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await userRepository.GetAllAsync();
        }
        public async Task<IEnumerable<User>> GetAllUsersWith()
        {
            return await userRepository.GetAllWithIncludesAsync(new List<Expression<Func<User, object>>>() { x => x.Orders});
        }

        public async Task<User> GetUserById(int id)
        {
            return await userRepository.GetByIdAsync(id);
        }
        public async Task<User> GetUserByName(string name)
        {
            return await userRepository.GetByNameAsync(name);
        }
        public async Task<User> AddUser(User user)
        {
            return await userRepository.AddAsync(user);
        }
        public async Task UpdateUser(User user)
        {
            await userRepository.UpdateAsync(user);
        }
        public async Task DeleteUserById(int id)
        {
            await userRepository.DeleteByIdAsync(id);
        }
    }
}
