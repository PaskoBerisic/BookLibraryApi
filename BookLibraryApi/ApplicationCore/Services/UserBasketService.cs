using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.BookUserBaskets;
using ApplicationCore.Specifications.UserBaskets;

namespace ApplicationCore.Services
{
    public class UserBasketService : IUserBasketService
    {
        private readonly IRepository<UserBasket> userBasketRepository;
        private readonly IRepository<BookUserBasket> bookUserBasketRepository;
        private readonly IRepository<Book> bookRepository;

        public UserBasketService(IRepository<UserBasket> userBasketRepository, IRepository<BookUserBasket> bookUserBasketRepository, IRepository<Book> bookRepository)
        {
            this.userBasketRepository = userBasketRepository;
            this.bookUserBasketRepository = bookUserBasketRepository;
            this.bookRepository = bookRepository;
        }

        public async Task<IEnumerable<UserBasket>> GetAllWithSpec()
        {
            var specification = new UserBasketsWithIncludesSpecification();
            return await userBasketRepository.GetAllWithSpecAsync(specification);
        }
        public async Task<UserBasket> GetSingleWithSpec(ISpecification<UserBasket> specification)
        {
            return await userBasketRepository.GetSingleWithSpecAsync(specification);
        }

        public async Task<UserBasket> GetById(int id)
        {
            var specification = new UserBasketByIdWithIncludesSpecification(id);
            return await userBasketRepository.GetSingleWithSpecAsync(specification);
        }

        public async Task<UserBasket> Add(UserBasket userBasket, ICollection<int> bookIds)
        {
            await userBasketRepository.AddAsync(userBasket);

            foreach (var bookId in bookIds)
            {
                await bookUserBasketRepository.AddAsync(new BookUserBasket { BookId = bookId, UserBasketId = userBasket.Id });
            }
            return userBasket;
        }

        public async Task Update(UserBasket userBasket, ICollection<int> bookIds)
        {
            await userBasketRepository.UpdateAsync(userBasket);

            var bookUserBaskets = await GetBookUserBasket(userBasket.Id);

            var bookIdsToDelete = bookUserBaskets.Select(x => x.BookId).Except(bookIds);
            var bookIdsToAdd = bookIds.Except(bookUserBaskets.Select(x => x.BookId));


            // delete books
            foreach (var book in bookUserBaskets.Where(x => bookIdsToDelete.Contains(x.BookId)))
            {
                await bookUserBasketRepository.DeleteAsync(book);
            }


            // add books
            foreach (var bookId in bookIdsToAdd)
            {
                await bookUserBasketRepository.AddAsync(new BookUserBasket { BookId = bookId, UserBasketId = userBasket.Id });
            }

        }

        public async Task Delete(UserBasket userBasket)
        {
            await userBasketRepository.DeleteAsync(userBasket);
        }

        public async Task DeleteById(int id)
        {
            await userBasketRepository.DeleteByIdAsync(id);
        }
        public async Task AddBookToUserBasket(int bookId, int userBasketId)
        {
            var specification = new BookUserBasketByBookIdSpecification(bookId, userBasketId);
            var bookUserBasket = await bookUserBasketRepository.GetSingleWithSpecAsync(specification);
            if (bookUserBasket is not null)
            {
                return;
            }
            await bookUserBasketRepository.AddAsync(new BookUserBasket { BookId = bookId, UserBasketId = userBasketId });
        }

        public async Task DeleteBookFromUserBasket(int bookId, int userBasketId)
        {
            var specification = new BookUserBasketByBookIdSpecification(bookId, userBasketId);
            var userBasket = await bookUserBasketRepository.GetSingleWithSpecAsync(specification);

            await bookUserBasketRepository.DeleteAsync(userBasket);
        }

        public async Task ClearBasket(int id)
        {
            var bookUserBaskets = await GetBookUserBasket(id);

            foreach (var book in bookUserBaskets)
            {
                book.Book.UnitNumber++;
                await bookRepository.UpdateAsync(book.Book);
                await bookUserBasketRepository.DeleteAsync(book);
            }
        }

        public async Task<IEnumerable<UserBasket>> FindWithSpecification(ISpecification<UserBasket> specification)
        {
            return await userBasketRepository.FindWithSpecificationAsync(specification);
        }

        public async Task<IEnumerable<BookUserBasket>> GetBookUserBasket(int userBasketId)
        {
            var bookUserBasketSpec = new BookUserBasketSpecification(userBasketId);
            var bookUserBaskets = await bookUserBasketRepository.GetAllWithSpecAsync(bookUserBasketSpec);

            return bookUserBaskets;
        }
    }
}

