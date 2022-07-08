﻿using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Book>? Books { get; set; }
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime Updated { get; set; }
    }
}
