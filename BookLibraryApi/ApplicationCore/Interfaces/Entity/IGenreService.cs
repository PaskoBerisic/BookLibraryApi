using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IGenreService
    {
        Task<IEnumerable<Genre>> GetAllWithSpec();
        Task<Genre> GetById(int id);
        Task<Genre> Add(Genre genre, ICollection<int> id);
        Task Update(Genre genre, ICollection<int> id);
        Task Delete(Genre genre);
        Task DeleteById(int id);
        Task<IEnumerable<Genre>> FindWithSpecification(ISpecification<Genre> specification = null);
    }
}
