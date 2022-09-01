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
        Task<IEnumerable<UserBasket>> GetAllWithSpec();
        Task<UserBasket> GetSingleWithSpec(ISpecification<UserBasket> specification);
        Task<UserBasket> GetById(int id);
        Task<UserBasket> Add(UserBasket userBasket, ICollection<int> id);
        Task Update(UserBasket userBasket, ICollection<int> id);
        Task Delete(UserBasket userBasket);
        Task DeleteById(int id);
        Task<IEnumerable<UserBasket>> FindWithSpecification(ISpecification<UserBasket> specification = null);
        Task AddBookToUserBasket(int bookId, int userBasketId);
        Task DeleteBookFromUserBasket(int bookId, int userBasketId);
    }
}
