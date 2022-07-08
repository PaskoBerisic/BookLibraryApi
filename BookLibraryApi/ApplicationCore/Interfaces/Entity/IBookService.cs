using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<IEnumerable<Book>> GetAllBooksWith();
        Task<IEnumerable<Book>> GetAllBooksWithAuthorsSpec(ISpecification<Book> specification);
        Task<Book> GetBookById(int id);
        Task<Book> GetBookByName(string name);
        Task<Book> AddBook(Book book);
        Task UpdateBook(Book book);
        Task DeleteBook(Book book);
        Task DeleteBookById(int id);
    }
}
