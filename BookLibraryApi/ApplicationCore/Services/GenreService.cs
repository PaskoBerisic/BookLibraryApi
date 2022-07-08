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
    public class GenreService : IGenreService
    {
        private readonly IRepository<Genre> genreRepository;
        public GenreService(IRepository<Genre> genreRepository)
        {
            this.genreRepository = genreRepository;
        }
        public async Task<IEnumerable<Genre>> GetAllGenresWith()
        {
            return await genreRepository.GetAllWithIncludesAsync(new List<Expression<Func<Genre, object>>>() { x => x.Books });
        }
        public async Task<IEnumerable<Genre>> GetGenresWithIds(ISpecification<Genre> specification)
        {
            return await genreRepository.GetAllWithSpecAsync(specification);
        }
        public async Task<Genre> GetGenreById(int id)
        {
            return await genreRepository.GetByIdAsync(id);
        }
        public async Task<Genre> AddGenre(Genre genre)
        {
            return await genreRepository.AddAsync(genre);
        }
        public async Task UpdateGenre(Genre genre)
        {
            await genreRepository.UpdateAsync(genre);
        }
        public async Task DeleteGenreById(int id)
        {
            await genreRepository.DeleteByIdAsync(id);
        }
    }
}
