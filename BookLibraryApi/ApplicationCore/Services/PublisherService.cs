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
    public class PublisherService : IPublisherService
    {
        private readonly IRepository<Publisher> publisherRepository;
        public PublisherService(IRepository<Publisher> publisherRepository)
        {
            this.publisherRepository = publisherRepository;
        }
        public async Task<IEnumerable<Publisher>> GetAllPublishersWith()
        {
            return await publisherRepository.GetAllWithIncludesAsync(new List<Expression<Func<Publisher, object>>>() { x => x.Books });
        }
        public async Task<Publisher> GetPublisherById(int id)
        {
            return await publisherRepository.GetByIdAsync(id);
        }
        public async Task<Publisher> AddPublisher(Publisher publisher)
        {
            return await publisherRepository.AddAsync(publisher);
        }
        public async Task UpdatePublisher(Publisher publisher)
        {
            await publisherRepository.UpdateAsync(publisher);
        }
        public async Task DeletePublisherById(int id)
        {
            await publisherRepository.DeleteByIdAsync(id);
        }
    }
}
