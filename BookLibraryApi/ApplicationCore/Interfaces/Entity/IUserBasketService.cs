using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IUserBasketService
    {
        Task<IEnumerable<UserBasket>> GetAllUserBaskets();
        Task<IEnumerable<UserBasket>> GetAllUserBasketsWith();
        Task<UserBasket> GetUserBasketById(int id);
        Task<UserBasket> AddUserBasket(UserBasket userBasket);
        Task UpdateUserBasket(UserBasket userBasket);
        Task DeleteUserBasketById(int id);
    }
}
