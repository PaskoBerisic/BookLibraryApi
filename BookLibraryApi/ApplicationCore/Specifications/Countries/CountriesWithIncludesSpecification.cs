using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.Countries
{
    public class CountriesWithIncludesSpecification : BaseSpecification<Country>
    {
        public CountriesWithIncludesSpecification() : base()
        {
            //AddInclude(x => x.Include(x => x.Authors));
        }
        //TODO: Think about connecting Authors and Countries MANY to MANY
    }
}
