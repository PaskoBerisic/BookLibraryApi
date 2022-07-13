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
    public class BookService2 : IBookService2
    {
        private readonly IRepository<Book> bookRepository;
        public BookService2(IRepository<Book> bookRepository)
        {
            this.bookRepository = bookRepository;
        }


        public async Task<IEnumerable<Book>> GetAll()
        {
            return await bookRepository.GetAllWithIncludesAsync(new List<Expression<Func<Book, object>>>() { x => x.Authors, x => x.Genres, x => x.Orders, x => x.Publisher, x => x.Language });
        }

        public async Task<IEnumerable<Book>> GetAllWith(ISpecification<Book> specification)
        {
            var books = await bookRepository.GetAllWithSpecAsync(specification);
            return books;
        }

        public async Task<IEnumerable<Book>> GetAllWithSpec(ISpecification<Book> specification)
        {
            return await bookRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<Book> GetById(int id)
        {
            return await bookRepository.GetByIdAsync(id);
        }
        public async Task<Book> Add(Book book)
        {
            return await bookRepository.AddAsync(book);
        }

        public async Task Update(Book book)
        {
            await bookRepository.UpdateAsync(book);
        }
        public async Task Delete(Book book)
        {
            await bookRepository.DeleteAsync(book);
        }
        public async Task DeleteById(int id)
        {
            await bookRepository.DeleteByIdAsync(id);
        }
    }
}
