using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.Books
{
    public class BooksByYearSpecification : BaseSpecification<Book>
    {
        public BooksByYearSpecification()
        {
            AddOrderByDescending(x => x.YearOfPublish);
        }
    }
}
