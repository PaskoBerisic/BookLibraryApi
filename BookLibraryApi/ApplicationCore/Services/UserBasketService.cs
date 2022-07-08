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
    public class UserBasketService : IUserBasketService
    {
        private readonly IRepository<UserBasket> userBasketRepository;
        public UserBasketService(IRepository<UserBasket> userBasketRepository)
        {
            this.userBasketRepository = userBasketRepository;
        }

        public async Task<IEnumerable<UserBasket>> GetAllUserBaskets()
        {
            return await userBasketRepository.GetAllAsync();

        }
        public async Task<IEnumerable<UserBasket>> GetAllUserBasketsWith()
        {
            return await userBasketRepository.GetAllWithIncludesAsync(new List<Expression<Func<UserBasket, object>>>() { x => x.Books });
        }
        public async Task<UserBasket> GetUserBasketById(int id)
        {
            return await userBasketRepository.GetByIdAsync(id);
        }
        public async Task<UserBasket> AddUserBasket(UserBasket userBasket)
        {
            return await userBasketRepository.AddAsync(userBasket);
        }
        public async Task UpdateUserBasket(UserBasket userBasket)
        {
            await userBasketRepository.UpdateAsync(userBasket);
        }
        public async Task DeleteUserBasketById(int id)
        {
            await userBasketRepository.DeleteByIdAsync(id);
        }
    }
    
}
