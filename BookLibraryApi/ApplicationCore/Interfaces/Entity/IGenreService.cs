using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IGenreService
    {
        Task<IEnumerable<Genre>> GetAllGenresWith();
        Task<IEnumerable<Genre>> GetGenresWithIds(ISpecification<Genre> specification);
        Task<Genre> GetGenreById(int id);
        Task<Genre> AddGenre(Genre genre);
        Task UpdateGenre(Genre genre);
        Task DeleteGenreById(int id);
    }
}
