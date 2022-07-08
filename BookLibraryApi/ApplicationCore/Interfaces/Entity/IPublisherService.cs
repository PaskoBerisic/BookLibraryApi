using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IPublisherService
    {
        Task<IEnumerable<Publisher>> GetAllPublishersWith();
        Task<Publisher> GetPublisherById(int id);
        Task<Publisher> AddPublisher(Publisher publisher);
        Task UpdatePublisher(Publisher publisher);
        Task DeletePublisherById(int id);
    }
}
