using System;
using System.Collections.Generic;

namespace SWD392_Assignment.Data.Models
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? ProductQuantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
        public int? ColorId { get; set; }

        public virtual Color? Color { get; set; }
        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
