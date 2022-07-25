using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllWith();
        Task<IEnumerable<Order>> GetAllWithSpec();
        Task<Order> GetById(int id);
        Task<Order> Add(Order author);
        Task Update(Order author);
        Task Delete(Order author);
        Task DeleteById(int id);

    }
}
