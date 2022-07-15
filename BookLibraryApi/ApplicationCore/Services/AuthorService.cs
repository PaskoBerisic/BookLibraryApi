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
    public class AuthorService : IAuthorService
    {
        private readonly IRepository<Author> authorRepository;
        private readonly IBookService2 bookService;
        public AuthorService(IRepository<Author> authorRepository, IBookService2 bookService)
        {
            this.authorRepository = authorRepository;
            this.bookService = bookService;
        }

        public async Task GetBooks(Author author)
        {
            var specification = new BooksForSpecification(author.Books.Select(x => x.Id).ToList());
            var authorBooks = (await bookService.GetAllWithSpec(specification)).ToList();
            authorBooks.AddRange(author.Books.Where(x => !authorBooks.Select(x => x.Id).Contains(x.Id)));
            author.Books = authorBooks;
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            return await authorRepository.GetAllWithIncludesAsync(new List<Expression<Func<Author, object>>>() { x => x.Books, y => y.Country });
        }

        public async Task<IEnumerable<Author>> GetAllWith(ISpecification<Author> specification)
        {
            var authors = await authorRepository.GetAllWithSpecAsync(specification);
            return authors;
        }

        public async Task<IEnumerable<Author>> GetAllWithSpec(ISpecification<Author> specification)
        {
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
    }
}
