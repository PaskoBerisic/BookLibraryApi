using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class CountryService : ICountryService
    {
        private readonly IRepository<Country> countryRepository;
        public CountryService(IRepository<Country> countryRepository)
        {
            this.countryRepository = countryRepository;
        }
        public async Task<IEnumerable<Country>> GetAllCountires()
        {
            return await countryRepository.GetAllAsync();
        }
        public async Task<Country> GetCountryById(int id)
        {
            return await countryRepository.GetByIdAsync(id);
        }
        public async Task<Country> AddCountry(Country country)
        {
            return await countryRepository.AddAsync(country);
        }
        public async Task UpdateCountry(Country country)
        {
            await countryRepository.UpdateAsync(country);
        }
        public async Task DeleteCountryById(int id)
        {
            await countryRepository.DeleteByIdAsync(id);
        }
    }
}
