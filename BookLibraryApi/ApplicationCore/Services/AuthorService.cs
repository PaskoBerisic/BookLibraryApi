using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Authors;
using ApplicationCore.Specifications.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepository<Author> authorRepository;
        private readonly IRepository<Book> bookRepository;
        public AuthorService(IRepository<Author> authorRepository, IRepository<Book> bookRepository)
        {
            this.authorRepository = authorRepository;
            this.bookRepository = bookRepository;
        }

        public async Task GetBooks(Author author)
        {
            var specification = new BooksForSpecification(author.Books.Select(x => x.Id).ToList());
            var authorBooks = (await bookRepository.FindWithSpecificationPattern(specification)).ToList();
            authorBooks.AddRange(author.Books.Where(x => !authorBooks.Select(x => x.Id).Contains(x.Id)));
            author.Books = authorBooks;
        }
        public async Task<IEnumerable<Author>> GetAllWith()
        {
            var authors = await authorRepository.GetAllWithIncludesAsync(new List<Expression<Func<Author, object>>>() { x => x.Books, y => y.Country });
            return authors;
        }

        public async Task<IEnumerable<Author>> GetAllWithSpec()
        {
            var specification = new AuthorsWithBooksAndCountriesSpec();
            return await authorRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<Author> GetById(int id)
        {
            return await authorRepository.GetByIdAsync(id);
        }
        public async Task<Author> Add(Author author)
        {
            await GetBooks(author);
            return await authorRepository.AddAsync(author);
        }
        public async Task Update(Author author)
        {
            await GetBooks(author);
            await authorRepository.UpdateAsync(author);
        }
        public async Task Delete(Author author)
        {
            await authorRepository.DeleteAsync(author);
        }
        public async Task DeleteById(int id)
        {
            await authorRepository.DeleteByIdAsync(id);
        }
        public async Task<IEnumerable<Author>> FindWithSpecificationPattern(ISpecification<Author> specification)
        {
            return await authorRepository.FindWithSpecificationPattern(specification);
        }
    }
}
