using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces.Entity
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetAllWithSpec();
        Task<Country> GetById(int id);
        Task<Country> Add(Country country);
        Task Update(Country country);
        Task Delete(Country country);
        Task DeleteById(int id);
    }
}
