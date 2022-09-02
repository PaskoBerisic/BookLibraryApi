using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.BookGenres;
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
        private readonly IRepository<BookGenre> bookGenreRepository;

        public GenreService(IRepository<Genre> genreRepository, IRepository<BookGenre> bookGenreRepository)
        {
            this.genreRepository = genreRepository;
            this.bookGenreRepository = bookGenreRepository;
        }
        public async Task<IEnumerable<Genre>> GetAllWithSpec()
        {
            var specification = new GenresWithIncludesSpecification();
            return await genreRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<Genre> GetById(int id)
        {
            var specification = new GenreByIdWithIncludesSpecification(id);
            return await genreRepository.GetSingleWithSpecAsync(specification);
        }
        public async Task<Genre> Add(Genre genre, ICollection<int> bookIds)
        {
            await genreRepository.AddAsync(genre);

            foreach (var bookId in bookIds)
            {
                await bookGenreRepository.AddAsync(new BookGenre { BookId = bookId, GenreId = genre.Id });
            }
            return genre;
        }
        public async Task Update(Genre genre, ICollection<int> bookIds)
        {
            await genreRepository.UpdateAsync(genre);

            var bookGenres = await GetBookGenres(genre.Id);

            var bookIdsToDelete = bookGenres.Select(x => x.BookId).Except(bookIds);
            var bookIdsToAdd = bookIds.Except(bookGenres.Select(x => x.BookId));


            // delete books
            foreach (var book in bookGenres.Where(x => bookIdsToDelete.Contains(x.BookId)))
            {
                await bookGenreRepository.DeleteAsync(book);
            }


            // add books
            foreach (var bookId in bookIdsToAdd)
            {
                await bookGenreRepository.AddAsync(new BookGenre { BookId = bookId, GenreId = genre.Id });
            }
        }

        public async Task Delete(Genre genre)
        {
            await genreRepository.DeleteAsync(genre);
        }

        public async Task DeleteById(int id)
        {
            await genreRepository.DeleteByIdAsync(id);
        }

        public async Task<IEnumerable<Genre>> FindWithSpecification(ISpecification<Genre> specification)
        {
            return await genreRepository.FindWithSpecificationAsync(specification);
        }

        public async Task<IEnumerable<BookGenre>> GetBookGenres(int genreId)
        {
            var bookGenreSpec = new BookGenreWithBookIncludeSpecification(genreId);
            var bookGenres = await bookGenreRepository.GetAllWithSpecAsync(bookGenreSpec);

            return bookGenres;
        }

    }
}
