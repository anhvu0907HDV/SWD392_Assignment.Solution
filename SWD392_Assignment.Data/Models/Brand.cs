﻿using System;
using System.Collections.Generic;

namespace SWD392_Assignment.Data.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}