using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public async Task<IEnumerable<Country>> GetAll()
        {
            return await countryRepository.GetAllWithIncludesAsync(new List<Expression<Func<Country, object>>>() { /* No use - FIND USE */});
        }

        public async Task<IEnumerable<Country>> GetAllWith(ISpecification<Country> specification)
        {
            var countrys = await countryRepository.GetAllWithSpecAsync(specification);
            return countrys;
        }

        public async Task<IEnumerable<Country>> GetAllWithSpec(ISpecification<Country> specification)
        {
            return await countryRepository.GetAllWithSpecAsync(specification);
        }

        public async Task<Country> GetById(int id)
        {
            return await countryRepository.GetByIdAsync(id);
        }
        public async Task<Country> Add(Country country)
        {
            return await countryRepository.AddAsync(country);
        }

        public async Task Update(Country country)
        {
            await countryRepository.UpdateAsync(country);
        }
        public async Task Delete(Country country)
        {
            await countryRepository.DeleteAsync(country);
        }
        public async Task DeleteById(int id)
        {
            await countryRepository.DeleteByIdAsync(id);
        }

    }
}
