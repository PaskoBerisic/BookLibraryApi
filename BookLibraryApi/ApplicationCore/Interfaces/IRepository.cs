﻿using System.Linq.Expressions;

namespace ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : class 
    {
        Task SaveChangesAsync();
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllWithSpecAsync(ISpecification<T> specification);
        Task<T> GetSingleWithSpecAsync(ISpecification<T> specification);
        Task<IEnumerable<T>> FindWithSpecificationAsync(ISpecification<T> specification = null);
        Task<T> GetByIdAsync<Tid>(Tid id) where Tid : notnull;
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteByIdAsync<Tid>(Tid id);
        Task<IEnumerable<T>> GetAllWithIncludesAsync(List<Expression<Func<T, object>>> includes);

    }

}
