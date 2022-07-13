using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications.Books
{
    public class BooksForSpecification : BaseSpecification<Book>
    {
        public BooksForSpecification(ICollection<int> bookIds) : base(x => bookIds.Contains(x.Id))
        {

        } 
    }
}