using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces.Entity
{
    public interface ILanguageService
    {
        Task<IEnumerable<Language>> GetAllWithSpec();
        Task<Language> GetById(int id);
        Task<Language> Add(Language language);
        Task Update(Language language);
        Task Delete(Language language);
        Task DeleteById(int id);
        Task<IEnumerable<Language>> FindWithSpecification(ISpecification<Language> specification = null);
    }
}
