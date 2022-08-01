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
        private readonly IBookService bookService;
        public UserBasketService(IRepository<UserBasket> userBasketRepository, IBookService bookService)
        {
            this.userBasketRepository = userBasketRepository;
            this.bookService = bookService;
        }
        public async Task GetBooks(UserBasket userBasket)
        {
            var specification = new BooksForSpecification(userBasket.Books.Select(x => x.Id).ToList());
            var basketBooks = (await bookService.FindWithSpecificationPattern(specification)).ToList();
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
    }

}

