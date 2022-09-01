using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Languages;

namespace ApplicationCore.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly IRepository<Language> languageRepository;
        private readonly IRepository<Book> bookRepository;

        public LanguageService(IRepository<Language> languageRepository, IRepository<Book> bookRepository)
        {
            this.languageRepository = languageRepository;
            this.bookRepository = bookRepository;
        }
        public async Task<IEnumerable<Language>> GetAllWithSpec()
        {
            return await languageRepository.GetAllAsync();
        }

        public async Task<Language> GetById(int id)
        {
            var specification = new LanguageByIdWithIncludesSpecification(id);
            return await languageRepository.GetSingleWithSpecAsync(specification);
        }
        public async Task<Language> Add(Language language)
        {
            return await languageRepository.AddAsync(language);
        }
        public async Task Update(Language language)
        {
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

        public async Task<IEnumerable<Language>> FindWithSpecification(ISpecification<Language> specification)
        {
            return await languageRepository.FindWithSpecificationAsync(specification);
        }
    }
}
