using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAllAuthors();
        Task<IEnumerable<Author>> GetAllAuthorsWith();
        Task<IEnumerable<Author>> GetAuthorWithIds(ISpecification<Author> specification);
        Task<Author> GetAuthorById(int id);
        Task<Author> GetAuthorByName(string name);
        Task<Author> AddAuthor(Author author);
        Task UpdateAuthor(Author author);
        Task DeleteAuthor(Author author);
        Task DeleteAuthorById(int id);

    }
}
