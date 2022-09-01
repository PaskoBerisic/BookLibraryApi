using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IGenreService
    {
        Task<IEnumerable<Genre>> GetAllWith();
        Task<IEnumerable<Genre>> GetAllWithSpec();
        Task<Genre> GetById(int id);
        Task<Genre> Add(Genre genre);
        Task Update(Genre genre);
        Task Delete(Genre genre);
        Task DeleteById(int id);

    }
}
