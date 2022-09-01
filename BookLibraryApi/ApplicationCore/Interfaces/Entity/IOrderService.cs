using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllWithSpec();
        Task<Order> GetById(int id);
        Task<Order> Add(Order order, ICollection<int> id);
        Task Update(Order order, ICollection<int> id);
        Task Delete(Order order);
        Task DeleteById(int id);
        Task<IEnumerable<Order>> FindWithSpecification(ISpecification<Order> specification = null);
        Task<IEnumerable<Order>> FindOrdersForUser(int id);

    }
}
