using System;
using System.Collections.Generic;

namespace SWD392_Assignment.Data.Models
{
    public partial class Discountproduct
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? DiscountId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? Reason { get; set; }

        public virtual Discount? Discount { get; set; }
        public virtual Product? Product { get; set; }
    }
}
