using System;
using System.Collections.Generic;

namespace SWD392_Assignment.Data.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? StaffId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
