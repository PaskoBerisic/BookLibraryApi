using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Authors;
using ApplicationCore.Specifications.Genres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> bookRepository;
        private readonly IAuthorService authorService;
        private readonly IGenreService genreService;

        public BookService(IRepository<Book> bookRepository, IAuthorService authorService, IGenreService genreService)
        {
            this.bookRepository = bookRepository;
            this.authorService = authorService;
            this.genreService = genreService;
        }
        public async Task GetAuthors(Book book)
        {
            var specification = new AuthorsForBookSpecification(book.Authors.Select(x => x.Id).ToList());
            var bookAuthors = (await authorService.GetAllWithSpec(specification)).ToList();
            bookAuthors.AddRange(book.Authors.Where(x => !bookAuthors.Select(x => x.Id).Contains(x.Id)));
            book.Authors = bookAuthors;
        }
        public async Task GetGenres(Book book)
        {
            var specification = new GenresForBooksSpecification(book.Genres.Select(x => x.Id).ToList());
            var bookGenres = (await genreService.GetAllWithSpec(specification)).ToList();
            bookGenres.AddRange(book.Genres.Where(x => !bookGenres.Select(x => x.Id).Contains(x.Id)));
            book.Genres = bookGenres;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await bookRepository.GetAllWithIncludesAsync(new List<Expression<Func<Book, object>>>() { x => x.Authors, x => x.Genres, x => x.Orders, x => x.Publisher, x => x.Language });
        }

        public async Task<IEnumerable<Book>> GetAllWith(ISpecification<Book> specification)
        {
            var books = await bookRepository.GetAllWithSpecAsync(specification);
            return books;
        }

        public async Task<IEnumerable<Book>> GetAllWithSpec(ISpecification<Book> specification)
        {
            return await bookRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<Book> GetById(int id)
        {
            return await bookRepository.GetByIdAsync(id);
        }
        public async Task<Book> Add(Book book)
        {
            await GetAuthors(book);
            await GetGenres(book);
            return await bookRepository.AddAsync(book);
        }

        public async Task Update(Book book)
        {
            await GetAuthors(book);
            await GetGenres(book);
            await bookRepository.UpdateAsync(book);
        }
        public async Task Delete(Book book)
        {
            await bookRepository.DeleteAsync(book);
        }
        public async Task DeleteById(int id)
        {
            await bookRepository.DeleteByIdAsync(id);
        }

        //public async Task<IEnumerable<Book>> FindWithSpecificationPattern(ISpecification<Book> specification = null)
        //{
        //    return await bookRepository.GetAllWithSpecAsync(specification);
        //}

        public async Task<IEnumerable<Book>> FindWithSpecificationPattern(ISpecification<Book> specification)
        {
            return await bookRepository.FindWithSpecificationPattern(specification);
        }
    }
}

