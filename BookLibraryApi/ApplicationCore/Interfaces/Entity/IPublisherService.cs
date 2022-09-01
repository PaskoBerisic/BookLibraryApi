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
        Task<IEnumerable<Publisher>> GetAllWithSpec();
        Task<Publisher> GetById(int id);
        Task<Publisher> Add(Publisher publisher);
        Task Update(Publisher publisher);
        Task Delete(Publisher publisher);
        Task DeleteById(int id);
        Task<IEnumerable<Publisher>> FindWithSpecification(ISpecification<Publisher> specification = null);
    }
}
