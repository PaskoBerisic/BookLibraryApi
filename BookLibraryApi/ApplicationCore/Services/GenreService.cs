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
    public class GenreService : IGenreService
    {
        private readonly IRepository<Genre> genreRepository;
        private readonly IBookService2 bookService;
        public GenreService(IRepository<Genre> genreRepository, IBookService2 bookService)
        {
            this.genreRepository = genreRepository;
            this.bookService = bookService;
        }

        public async Task GetBooks(Genre genre)
        {
            var specification = new BooksForSpecification(genre.Books.Select(x => x.Id).ToList());
            var genreBooks = (await bookService.GetAllWithSpec(specification)).ToList();
            genreBooks.AddRange(genre.Books.Where(x => !genreBooks.Select(x => x.Id).Contains(x.Id)));
            genre.Books = genreBooks;
        }

        public async Task<IEnumerable<Genre>> GetAll()
        {
            return await genreRepository.GetAllWithIncludesAsync(new List<Expression<Func<Genre, object>>>() { x => x.Books});
        }

        public async Task<IEnumerable<Genre>> GetAllWith(ISpecification<Genre> specification)
        {
            var genres = await genreRepository.GetAllWithSpecAsync(specification);
            return genres;
        }

        public async Task<IEnumerable<Genre>> GetAllWithSpec(ISpecification<Genre> specification)
        {
            return await genreRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<Genre> GetById(int id)
        {
            return await genreRepository.GetByIdAsync(id);
        }
        public async Task<Genre> Add(Genre genre)
        {
            await GetBooks(genre);
            return await genreRepository.AddAsync(genre);
        }

        public async Task Update(Genre genre)
        {
            await GetBooks(genre);
            await genreRepository.UpdateAsync(genre);
        }
        public async Task Delete(Genre genre)
        {
            await genreRepository.DeleteAsync(genre);
        }
        public async Task DeleteById(int id)
        {
            await genreRepository.DeleteByIdAsync(id);
        }
    }
}
