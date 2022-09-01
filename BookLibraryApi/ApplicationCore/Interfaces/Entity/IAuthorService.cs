using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAllWithSpec();
        Task<Author> GetById(int id);
        Task<Author> Add(Author author, ICollection<int> id);
        Task Update(Author author, ICollection<int> id);
        Task DeleteById(int id);
        Task<IEnumerable<Author>> FindWithSpecification(ISpecification<Author> specification = null);
    }
}
