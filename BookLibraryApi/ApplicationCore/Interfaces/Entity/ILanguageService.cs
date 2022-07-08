using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface ILanguageService
    {
        Task<IEnumerable<Language>> GetAllLanguagesWith();
        Task<Language> GetLanguageById(int id);
        Task<Language> AddLanguage(Language language);
        Task UpdateLanguage(Language language);
        Task DeleteLanguageById(int id);

    }
}
