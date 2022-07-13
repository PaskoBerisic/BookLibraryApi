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

        public async Task<IEnumerable<UserBasket>> GetAll()
        {
            return await userBasketRepository.GetAllWithIncludesAsync(new List<Expression<Func<UserBasket, object>>>() { x => x.Books });
        }

        public async Task<IEnumerable<UserBasket>> GetAllWith(ISpecification<UserBasket> specification)
        {
            return await userBasketRepository.GetAllWithIncludesAsync(new List<Expression<Func<UserBasket, object>>>() { x => x.Books });
        }

        public async Task<IEnumerable<UserBasket>> GetAllWithSpec(ISpecification<UserBasket> specification)
        {
            return await userBasketRepository.GetAllWithIncludesAsync(new List<Expression<Func<UserBasket, object>>>() { x => x.Books });
        }

        public async Task<UserBasket> GetById(int id)
        {
            return await userBasketRepository.GetByIdAsync(id);
        }
        public async Task<UserBasket> Add(UserBasket userBasket)
        {
            return await userBasketRepository.AddAsync(userBasket);
        }

        public async  Task Update(UserBasket userBasket)
        {
            await userBasketRepository.UpdateAsync(userBasket);
        }
        public async Task Delete(UserBasket userBasket)
        {
            await userBasketRepository.DeleteAsync(userBasket);
        }

        public async Task DeleteById(int id)
        {
            await userBasketRepository.DeleteByIdAsync(id);
        }

    }

}

