using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Bibliography { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime Updated { get; set; }
        // One to Many
        public int CountryId { get; set; }
        public Country? Country { get; set; }
        // Many to Many
        public ICollection<Book>? Books { get; set; }
    }
}
