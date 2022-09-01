using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IUserBasketService
    {
        Task<IEnumerable<UserBasket>> GetAllWith();
        Task<IEnumerable<UserBasket>> GetAllWithSpec();
        Task<UserBasket> GetById(int id);
        Task<UserBasket> Add(UserBasket userBasket);
        Task Update(UserBasket userBasket);
        Task Delete(UserBasket userBasket);
        Task DeleteById(int id);
        Task AddBookToUserBasket(int id, UserBasket userBasket);
        Task DeleteBookFromUserBasket(int id, UserBasket userBasket);
        void CalculateBasket(UserBasket userBasket);

    }
}
