using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Books;

namespace ApplicationCore.Services
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> bookRepository;
        private readonly IRepository<BookAuthor> bookAuthorRepository;
        private readonly IRepository<BookGenre> bookGenreRepository;

        public BookService(IRepository<Book> bookRepository, IRepository<BookAuthor> bookAuthorRepository, IRepository<BookGenre> bookGenreRepository)
        {
            this.bookRepository = bookRepository;
            this.bookAuthorRepository = bookAuthorRepository;
            this.bookGenreRepository = bookGenreRepository;
        }

        public async Task<IEnumerable<Book>> GetAllWithSpec()
        {
            var specification = new BooksWithIncludesSpecification();
            return await bookRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<Book> GetById(int id)
        {
            var specification = new BookByIdWithIncludesSpecification(id);
            return await bookRepository.GetSingleWithSpecAsync(specification);
        }
        public async Task<Book> Add(Book book, ICollection<int> authorIds, ICollection<int> genreIds)
        {
            await bookRepository.AddAsync(book);

            foreach (var authorId in authorIds)
            {
                await bookAuthorRepository.AddAsync(new BookAuthor { AuthorId = authorId, BookId = book.Id });
            }
            foreach (var genreId in genreIds)
            {
                await bookGenreRepository.AddAsync(new BookGenre { GenreId = genreId, BookId = book.Id });
            }
            return book;
        }
        public async Task Update(Book book, ICollection<int> authorIds, ICollection<int> genreIds)
        {
            await bookRepository.UpdateAsync(book);

            var bookAuthors = await GetBookAuthors(book.Id);

            var authorIdsToDelete = bookAuthors.Select(x => x.AuthorId).Except(authorIds);
            var authorIdsToAdd = authorIds.Except(bookAuthors.Select(x => x.AuthorId));

            // delete authors
            foreach (var author in bookAuthors.Where(x => authorIdsToDelete.Contains(x.AuthorId)))
            {
                await bookAuthorRepository.DeleteAsync(author);
            }

            // add authors
            foreach (var authorId in authorIdsToAdd)
            {
                await bookAuthorRepository.AddAsync(new BookAuthor { BookId = book.Id, AuthorId = authorId });
            }


            var bookGenres = await GetBookGenres(book.Id);

            var genreIdsToDelete = bookGenres.Select(x => x.GenreId).Except(genreIds);
            var genreIdsToAdd = genreIds.Except(bookGenres.Select(x => x.GenreId));

            // delete genres
            foreach (var genre in bookGenres.Where(x => genreIdsToDelete.Contains(x.GenreId)))
            {
                await bookGenreRepository.DeleteAsync(genre);
            }

            // add genre
            foreach (var genreId in genreIdsToAdd)
            {
                await bookGenreRepository.AddAsync(new BookGenre { BookId = book.Id, GenreId = genreId });
            }
        }
        public async Task Delete(Book book)
        {
            await bookRepository.DeleteAsync(book);
        }
        public async Task DeleteById(int id)
        {
            await bookRepository.DeleteByIdAsync(id);
        }
        public async Task<IEnumerable<Book>> FindWithSpecification(ISpecification<Book> specification)
        {
            return await bookRepository.FindWithSpecificationAsync(specification);
        }

        public async Task<IEnumerable<BookAuthor>> GetBookAuthors(int bookId)
        {
            var bookAuthorSpec = new BookAuthorWithAuthorIncludeSpecification(bookId);
            var bookAuthors = await bookAuthorRepository.GetAllWithSpecAsync(bookAuthorSpec);

            return bookAuthors;
        }

        public async Task<IEnumerable<BookGenre>> GetBookGenres(int bookId)
        {
            var bookGenreSpec = new BookGenreWithGenreIncludeSpecification(bookId);
            var bookGenres = await bookGenreRepository.GetAllWithSpecAsync(bookGenreSpec);

            return bookGenres;
        }
    }
}

