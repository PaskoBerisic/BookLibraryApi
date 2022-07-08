using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.Genres
{
    public class GenresForBooksSpecification : BaseSpecification<Genre>
    {
        public GenresForBooksSpecification(ICollection<int> genresIds) : base(x => genresIds.Contains(x.Id))
        {

        }
    }
}
