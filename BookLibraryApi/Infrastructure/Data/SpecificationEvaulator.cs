﻿using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Data
{
    public class SpecificationEvaulator<T> where T : class
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification)
        {
            var query = inputQuery;

            if (specification.Criteria is not null)
            {
                query = query.Where(specification.Criteria);
            }

            if (specification.Includes.Any())
            {
                query = specification.Includes.Aggregate(query, (current, include) => current.Include(include));
            }
            return query;
        }
    }
}
