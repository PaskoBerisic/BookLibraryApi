using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Books;
using ApplicationCore.Specifications.Publishers;

namespace ApplicationCore.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IRepository<Publisher> publisherRepository;
        private readonly IRepository<Book> bookRepository;

        public PublisherService(IRepository<Publisher> publisherRepository, IRepository<Book> bookRepository)
        {
            this.publisherRepository = publisherRepository;
            this.bookRepository = bookRepository;
        }

        public async Task<IEnumerable<Publisher>> GetAllWithSpec()
        {
            var specification = new PublisherByIdWithIncludesSpecification();
            return await publisherRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<Publisher> GetById(int id)
        {
            var specification = new PublisherByIdWithIncludesSpecification(id);
            return await publisherRepository.GetSingleWithSpecAsync(specification);
        }

        public async Task<Publisher> Add(Publisher publisher)
        {
            return await publisherRepository.AddAsync(publisher);
        }
        public async Task Update(Publisher publisher)
        {
            await publisherRepository.UpdateAsync(publisher);
        }

        public async Task Delete(Publisher publisher)
        {
            await publisherRepository.DeleteAsync(publisher);
        }

        public async Task DeleteById(int id)
        {
            await publisherRepository.DeleteByIdAsync(id);
        }

        public async Task<IEnumerable<Publisher>> FindWithSpecification(ISpecification<Publisher> specification)
        {
            return await publisherRepository.FindWithSpecificationAsync(specification);
        }

        public async Task<ICollection<Book>> GetBooks(ICollection<int> bookIds)
        {
            var specification = new BookByIdWithIncludesSpecification(bookIds);
            var books = (await bookRepository.FindWithSpecificationAsync(specification)).ToList();
            return books;
        }
    }
}
