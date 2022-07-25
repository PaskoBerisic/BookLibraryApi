using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetAllWith();
        Task<IEnumerable<Country>> GetAllWithSpec();
        Task<Country> GetById(int id);
        Task<Country> Add(Country author);
        Task Update(Country author);
        Task Delete(Country author);
        Task DeleteById(int id);
    }
}
