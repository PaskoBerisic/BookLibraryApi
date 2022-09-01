using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace ApplicationCore.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification()
        {

        }
        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public Expression<Func<T, bool>> Criteria { get; private set; }
        public List<Func<IQueryable<T>, IIncludableQueryable<T, object?>>> Includes { get; } = new List<Func<IQueryable<T>, IIncludableQueryable<T, object?>>>();
        public Expression<Func<T, object>> OrderBy { get; private set; }
        public Expression<Func<T, object>> OrderByDescending { get; private set; }

        protected void SetCriteria(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }
        protected virtual void AddInclude(Func<IQueryable<T>, IIncludableQueryable<T, object?>> include)
        {
            Includes.Add(include);
        }

        protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
        }
        protected void AddOrderByDescending(Expression<Func<T, object>> orderByDescExpression)
        {
            OrderByDescending = orderByDescExpression;
        }
    }
}
