using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.Authors
{
    public class AuthorsForBookSpecification : BaseSpecification<Author>
    {
        public AuthorsForBookSpecification(ICollection<int> authorIds) : base(x => authorIds.Contains(x.Id)) 
        {
            
        }
    }
}
