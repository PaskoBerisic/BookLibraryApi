using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BookLibraryContext context;
        public Repository(BookLibraryContext context)
        {
            this.context = context;
        }
        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }
        public async Task<T> AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            await SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            context.Update(entity);
            await SaveChangesAsync();
        }
        public async Task DeleteAsync(T entity)
        {
            context.Remove(entity);
            await SaveChangesAsync();
        }
    }
}
