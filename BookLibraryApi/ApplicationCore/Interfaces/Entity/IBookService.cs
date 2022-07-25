using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllWith();
        Task<IEnumerable<Book>> GetAllWithSpec();
        Task<Book> GetById(int id);
        Task<Book> Add(Book author);
        Task Update(Book author);
        Task Delete(Book author);
        Task DeleteById(int id);
        Task<IEnumerable<Book>> FindWithSpecificationPattern(ISpecification<Book> specification = null);
    }
}


//Task<IEnumerable<Book>> GetAllBooks();
//Task<IEnumerable<Book>> GetAllBooksWith();
//Task<IEnumerable<Book>> GetBooksWithIds(ISpecification<Book> specification);
//Task<IEnumerable<Book>> GetAllBooksWithBooksSpec(ISpecification<Book> specification);
//Task<Book> GetBookById(int id);
//Task<Book> GetBookByName(string name);
//Task<Book> AddBook(Book book);
//Task UpdateBook(Book book);
//Task DeleteBook(Book book);
//Task DeleteBookById(int id);
