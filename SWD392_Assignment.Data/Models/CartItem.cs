using System;
using System.Collections.Generic;

namespace SWD392_Assignment.Data.Models
{
    public partial class CartItem
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? CartId { get; set; }

        public virtual Cart? Cart { get; set; }
        public virtual Product? Product { get; set; }
    }
}
