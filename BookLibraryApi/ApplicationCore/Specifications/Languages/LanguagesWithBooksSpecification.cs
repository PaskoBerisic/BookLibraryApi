using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.Languages
{
    public class LanguagesWithBooksSpecification : BaseSpecification<Language>
    {
        public LanguagesWithBooksSpecification() : base()
        {
            AddInclude(x => x.Books);
        }
    }
}
