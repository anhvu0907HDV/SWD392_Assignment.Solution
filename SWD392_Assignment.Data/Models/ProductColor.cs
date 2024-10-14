using System;
using System.Collections.Generic;

namespace SWD392_Assignment.Data.Models
{
    public partial class ProductColor
    {
        public int Id { get; set; }
        public int? ColorId { get; set; }
        public int? ProductId { get; set; }

        public virtual Color? Color { get; set; }
        public virtual Product? Product { get; set; }
    }
}
