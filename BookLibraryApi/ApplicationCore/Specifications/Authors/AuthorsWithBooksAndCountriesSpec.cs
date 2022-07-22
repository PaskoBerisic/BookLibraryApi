using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.Authors
{
    public class AuthorsWithBooksAndCountriesSpec : BaseSpecification<Author>
    {
        public AuthorsWithBooksAndCountriesSpec() : base()
        {
            AddInclude(x => x.Include(x => x.Books));
            AddInclude(x => x.Include(x => x.Country));
        }
    }
}


//AddInclude(x => x.Include(x => x.Books).ThenInclude(x => x.Genres));

