using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllWithSpec();
        Task<Book> GetById(int id);
        Task<Book> Add(Book book, ICollection<int> authorId, ICollection<int> genreId);
        Task Update(Book book, ICollection<int> authorId, ICollection<int> genreId);
        Task Delete(Book book);
        Task DeleteById(int id);
        Task<IEnumerable<Book>> FindWithSpecification(ISpecification<Book> specification = null);
    }
}
