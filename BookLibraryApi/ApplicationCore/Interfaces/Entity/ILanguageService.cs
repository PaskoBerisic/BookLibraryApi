using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface ILanguageService
    {
        Task<IEnumerable<Language>> GetAllWith();
        Task<IEnumerable<Language>> GetAllWithSpec();
        Task<Language> GetById(int id);
        Task<Language> Add(Language language);
        Task Update(Language language);
        Task Delete(Language language);
        Task DeleteById(int id);

    }
}
