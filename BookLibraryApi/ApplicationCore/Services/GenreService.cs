using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Books;
using ApplicationCore.Specifications.Genres;
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
        private readonly IRepository<Book> bookRepository;
        public GenreService(IRepository<Genre> genreRepository, IRepository<Book> bookRepository)
        {
            this.genreRepository = genreRepository;
            this.bookRepository = bookRepository;
        }

        public async Task GetBooks(Genre genre)
        {
            var specification = new BooksForSpecification(genre.Books.Select(x => x.Id).ToList());
            var authorBooks = (await bookRepository.FindWithSpecificationAsync(specification)).ToList();
            authorBooks.AddRange(genre.Books.Where(x => !authorBooks.Select(x => x.Id).Contains(x.Id)));
            genre.Books = authorBooks;
        }
        public async Task<IEnumerable<Genre>> GetAllWith()
        {
            var genres = await genreRepository.GetAllWithIncludesAsync(new List<Expression<Func<Genre, object>>>() { x => x.Books });
            return genres;
        }

        public async Task<IEnumerable<Genre>> GetAllWithSpec()
        {
            var specification = new GenresWithBooksSpecification();
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
