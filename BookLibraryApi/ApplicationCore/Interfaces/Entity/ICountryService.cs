using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetAllCountires();
        Task<Country> GetCountryById(int id);
        Task<Country> AddCountry(Country country);
        Task UpdateCountry(Country country);
        Task DeleteCountryById(int id);
    }
}
