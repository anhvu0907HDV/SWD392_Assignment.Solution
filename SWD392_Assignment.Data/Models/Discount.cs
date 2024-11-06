using System;
using System.Collections.Generic;

namespace SWD392_Assignment.Data.Models
{
    public partial class Discount
    {
        public Discount()
        {
            Discountproducts = new HashSet<Discountproduct>();
        }

        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string? DisName { get; set; }
        public double? DisAmount { get; set; }
        public int? IsPercentage { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? IsActive { get; set; }

        public virtual Product? Product { get; set; }
        public virtual ICollection<Discountproduct> Discountproducts { get; set; }
    }
}
