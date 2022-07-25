using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAllWith();
        Task<IEnumerable<Author>> GetAllWithSpec();
        Task<Author> GetById(int id);
        Task<Author> Add(Author author);
        Task Update(Author author);
        Task Delete(Author author);
        Task DeleteById(int id);

    }
}
