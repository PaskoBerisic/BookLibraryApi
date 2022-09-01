using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllWithSpec();
        Task<User> GetById(int id);
        Task<User> GetByUsername(string username);
        Task<User> Add(User user);
        Task Update(User user);
        Task DeleteById(int id);
        Task<IEnumerable<User>> FindWithSpecification(ISpecification<User> specification = null);
        Task<IEnumerable<Order>> FindOrders(User user);
    }
}
