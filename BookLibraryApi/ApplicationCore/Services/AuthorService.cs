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
    public class AuthorService : IAuthorService
    {
        private readonly IRepository<Author> authorRepository;
        public AuthorService(IRepository<Author> authorRepository)
        {
            this.authorRepository = authorRepository;
        }
        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await authorRepository.GetAllAsync();
        }
        public async Task<IEnumerable<Author>> GetAllAuthorsWith()
        {
            return await authorRepository.GetAllWithIncludesAsync(new List<Expression<Func<Author, object>>>() { x => x.Books, y => y.Country });
        }
        public async Task<IEnumerable<Author>> GetAuthorWithIds(ISpecification<Author> specification)
        {
            return await authorRepository.GetAllWithSpecAsync(specification);
        }
        public async Task<Author> GetAuthorById(int id)
        {
            return await authorRepository.GetByIdAsync(id);
        }
        public async Task<Author> GetAuthorByName(string name)
        {
            return await authorRepository.GetByNameAsync(name);
        }
        public async Task<Author> AddAuthor(Author author)
        {
            return await authorRepository.AddAsync(author);
        }
        public async Task UpdateAuthor(Author author)
        {
            await authorRepository.UpdateAsync(author);
        }
        public async Task DeleteAuthor(Author author)
        {
            await authorRepository.DeleteAsync(author);
        }
        public async Task DeleteAuthorById(int id)
        {
            await authorRepository.DeleteByIdAsync(id);
        }
    }
}
