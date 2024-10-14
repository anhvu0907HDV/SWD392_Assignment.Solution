using System;
using System.Collections.Generic;

namespace SWD392_Assignment.Data.Models
{
    public partial class Color
    {
        public Color()
        {
            OrderItems = new HashSet<OrderItem>();
            ProductColors = new HashSet<ProductColor>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImagePath { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<ProductColor> ProductColors { get; set; }
    }
}
