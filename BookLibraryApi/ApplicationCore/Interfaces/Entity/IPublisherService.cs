using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IPublisherService
    {
        Task<IEnumerable<Publisher>> GetAllWith();
        Task<IEnumerable<Publisher>> GetAllWithSpec();
        Task<Publisher> GetById(int id);
        Task<Publisher> Add(Publisher author);
        Task Update(Publisher author);
        Task Delete(Publisher author);
        Task DeleteById(int id);

    }
}
