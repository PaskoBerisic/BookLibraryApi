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
        Task<UserBasket> Add(UserBasket author);
        Task Update(UserBasket author);
        Task Delete(UserBasket author);
        Task DeleteById(int id);

    }
}
