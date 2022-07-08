using ApplicationCore.Enums;
using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Adress { get; set; }
        public Role Role { get; set; }
        public int OrderId { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime Updated { get; set; }
    }
}
