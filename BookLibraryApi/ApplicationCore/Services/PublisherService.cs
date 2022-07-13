using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Books;
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
        private readonly IBookService bookService;
        public PublisherService(IRepository<Publisher> publisherRepository, IBookService bookService)
        {
            this.publisherRepository = publisherRepository;
            this.bookService = bookService;
        }
        public async Task GetBooks(Publisher publisher)
        {
            var specification = new BooksForSpecification(publisher.Books.Select(x => x.Id).ToList());
            var publisherBooks = (await bookService.GetAllWithSpec(specification)).ToList();
            publisherBooks.AddRange(publisher.Books.Where(x => !publisherBooks.Select(x => x.Id).Contains(x.Id)));
            publisher.Books = publisherBooks;
        }
        public async Task<IEnumerable<Publisher>> GetAll()
        {
            return await publisherRepository.GetAllWithIncludesAsync(new List<Expression<Func<Publisher, object>>>() { x => x.Books });
        }

        public async Task<IEnumerable<Publisher>> GetAllWith(ISpecification<Publisher> specification)
        {
            var publishers = await publisherRepository.GetAllWithSpecAsync(specification);
            return publishers;
        }

        public async Task<IEnumerable<Publisher>> GetAllWithSpec(ISpecification<Publisher> specification)
        {
            return await publisherRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<Publisher> GetById(int id)
        {
            return await publisherRepository.GetByIdAsync(id);
        }
        public async Task<Publisher> Add(Publisher publisher)
        {
            await GetBooks(publisher);
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
    }
}
