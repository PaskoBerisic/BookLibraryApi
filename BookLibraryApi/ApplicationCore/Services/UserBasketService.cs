using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Books;
using ApplicationCore.Specifications.UserBaskets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class UserBasketService : IUserBasketService
    {
        private readonly IRepository<UserBasket> userBasketRepository;
        private readonly IRepository<Book> bookRepository;
        public UserBasketService(IRepository<UserBasket> userBasketRepository, IRepository<Book> bookRepository)
        {
            this.userBasketRepository = userBasketRepository;
            this.bookRepository = bookRepository;
        }
        public async Task GetBooks(UserBasket userBasket)
        {
            var specification = new BooksForSpecification(userBasket.Books.Select(x => x.Id).ToList());
            var basketBooks = (await bookRepository.FindWithSpecificationPattern(specification)).ToList();
            basketBooks.AddRange(userBasket.Books.Where(x => !basketBooks.Select(x => x.Id).Contains(x.Id)));
            userBasket.Books = basketBooks;
        }
        public async Task<IEnumerable<UserBasket>> GetAllWith()
        {
            return await userBasketRepository.GetAllWithIncludesAsync(new List<Expression<Func<UserBasket, object>>>() { x => x.Books });
        }

        public async Task<IEnumerable<UserBasket>> GetAllWithSpec()
        {
            var specification = new UserBasketsWithIncludesSpecification();
            return await userBasketRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<UserBasket> GetById(int id)
        {
            return await userBasketRepository.GetByIdAsync(id);
        }
        public async Task<UserBasket> Add(UserBasket userBasket)
        {
            await GetBooks(userBasket);
            return await userBasketRepository.AddAsync(userBasket);
        }
        public async  Task Update(UserBasket userBasket)
        {
            await GetBooks(userBasket);
            await userBasketRepository.UpdateAsync(userBasket);
        }
        public async Task Delete(UserBasket userBasket)
        {
            await userBasketRepository.DeleteAsync(userBasket);
        }
        public async Task DeleteById(int id)
        {
            await userBasketRepository.DeleteByIdAsync(id);
        }

        public async Task AddBookToUserBasket(int bookId, UserBasket userBasket)
        {
            var book = await bookRepository.GetByIdAsync(bookId);
            userBasket.Books.Add(book);
            CalculateBasket(userBasket);
            userBasketRepository.SaveChangesAsync();
        }
        public async Task DeleteBookFromUserBasket(int bookId, UserBasket userBasket)
        {
            var book = await bookRepository.GetByIdAsync(bookId);
            userBasket.Books.Remove(book);
            CalculateBasket(userBasket);
            userBasketRepository.SaveChangesAsync();
        }

        public void CalculateBasket(UserBasket userBasket)
        {
            decimal sum = 0;
            foreach(var book in userBasket.Books)
            {
                sum += book.RentalPrice;
            }
            userBasket.TotalRentalPrice = sum;
            userBasket.TotalRentalPriceWithVAT = Decimal.Multiply(userBasket.TotalRentalPrice, 1.25m);
        }
    }

}

