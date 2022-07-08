using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
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
        public LanguageService(IRepository<Language> languageRepository)
        {
          this.languageRepository = languageRepository;
        }
        public async Task<IEnumerable<Language>> GetAllLanguagesWith()
        {
            return await languageRepository.GetAllWithIncludesAsync(new List<Expression<Func<Language, object>>>() { x => x.Books });
        }
        public async Task<Language> GetLanguageById(int id)
        {
            return await languageRepository.GetByIdAsync(id);
        }
        public async Task<Language> AddLanguage(Language language)
        {
            return await languageRepository.AddAsync(language);
        }
        public async Task UpdateLanguage(Language language)
        {
            await languageRepository.UpdateAsync(language);
        }
        public async Task DeleteLanguageById(int id)
        {
            await languageRepository.DeleteByIdAsync(id);
        }
    }
}
