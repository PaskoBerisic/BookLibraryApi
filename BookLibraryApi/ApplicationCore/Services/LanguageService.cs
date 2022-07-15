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
    public class LanguageService : ILanguageService
    {
        private readonly IRepository<Language> languageRepository;
        private readonly IBookService bookService;
        public LanguageService(IRepository<Language> languageRepository, IBookService bookService)
        {
          this.languageRepository = languageRepository;
            this.bookService = bookService;
        }

        public async Task GetBooks(Language language)
        {
            var specification = new BooksForSpecification(language.Books.Select(x => x.Id).ToList());
            var languageBooks = (await bookService.GetAllWithSpec(specification)).ToList();
            languageBooks.AddRange(language.Books.Where(x => !languageBooks.Select(x => x.Id).Contains(x.Id)));
            language.Books = languageBooks;
        }
        public async Task<IEnumerable<Language>> GetAll()
        {
            return await languageRepository.GetAllWithIncludesAsync(new List<Expression<Func<Language, object>>>() { x => x.Books });
        }

        public async Task<IEnumerable<Language>> GetAllWith(ISpecification<Language> specification)
        {
            var languages = await languageRepository.GetAllWithSpecAsync(specification);
            return languages;
        }

        public async Task<IEnumerable<Language>> GetAllWithSpec(ISpecification<Language> specification)
        {
            return await languageRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<Language> GetById(int id)
        {
            return await languageRepository.GetByIdAsync(id);
        }
        public async Task<Language> Add(Language language)
        {
            await GetBooks(language);
            return await languageRepository.AddAsync(language);
        }

        public async Task Update(Language language)
        {
            await GetBooks(language);
            await languageRepository.UpdateAsync(language);
        }
        public async Task Delete(Language language)
        {
            await languageRepository.DeleteAsync(language);
        }
        public async Task DeleteById(int id)
        {
            await languageRepository.DeleteByIdAsync(id);
        }
    }
}
