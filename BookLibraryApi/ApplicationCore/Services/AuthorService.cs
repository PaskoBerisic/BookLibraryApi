using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Authors;
using ApplicationCore.Specifications.BookAuthors;

namespace ApplicationCore.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepository<Author> authorRepository;
        private readonly IRepository<BookAuthor> bookAuthorRepository;

        public AuthorService(IRepository<Author> authorRepository, IRepository<BookAuthor> bookAuthorRepository)
        {
            this.authorRepository = authorRepository;
            this.bookAuthorRepository = bookAuthorRepository;
        }

        public async Task<IEnumerable<Author>> GetAllWithSpec()
        {
            var specification = new AuthorsWithIncludesSpecification();
            return await authorRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<Author> GetById(int id)
        {
            var specification = new AuthorByIdWithIncludesSpecification(id);
            return await authorRepository.GetSingleWithSpecAsync(specification);
        }

        public async Task<Author> Add(Author author, ICollection<int> bookIds)
        {
            await authorRepository.AddAsync(author);

            foreach (var bookId in bookIds)
            {
                await bookAuthorRepository.AddAsync(new BookAuthor { BookId = bookId, AuthorId = author.Id });
            }
            return author;
        }

        public async Task Update(Author author, ICollection<int> bookIds)
        {
            await authorRepository.UpdateAsync(author);

            var bookAuthors = await GetBookAuthors(author.Id);

            var bookIdsToDelete = bookAuthors.Select(x => x.BookId).Except(bookIds);
            var bookIdsToAdd = bookIds.Except(bookAuthors.Select(x => x.BookId));

            foreach (var book in bookAuthors.Where(x => bookIdsToDelete.Contains(x.BookId)))
            {
                await bookAuthorRepository.DeleteAsync(book);
            }

            foreach (var bookId in bookIdsToAdd)
            {
                await bookAuthorRepository.AddAsync(new BookAuthor { BookId = bookId, AuthorId = author.Id });
            }
        }

        public async Task DeleteById(int id)
        {
            await authorRepository.DeleteByIdAsync(id);
        }
        public async Task<IEnumerable<Author>> FindWithSpecification(ISpecification<Author> specification)
        {
            return await authorRepository.FindWithSpecificationAsync(specification);
        }

        public async Task<IEnumerable<BookAuthor>> GetBookAuthors(int authorId)
        {
            var bookAuthorSpec = new BookAuthorWithBookIncludeSpecification(authorId);
            var bookAuthors = await bookAuthorRepository.GetAllWithSpecAsync(bookAuthorSpec);

            return bookAuthors;
        }
    }
}
