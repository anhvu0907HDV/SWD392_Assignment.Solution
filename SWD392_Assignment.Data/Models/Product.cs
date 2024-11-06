using System;
using System.Collections.Generic;

namespace SWD392_Assignment.Data.Models
{
    public partial class Product
    {
        public Product()
        {
            CartItems = new HashSet<CartItem>();
            Discountproducts = new HashSet<Discountproduct>();
            Discounts = new HashSet<Discount>();
            Feedbacks = new HashSet<Feedback>();
            OrderItems = new HashSet<OrderItem>();
            ProductAttachments = new HashSet<ProductAttachment>();
            ProductColors = new HashSet<ProductColor>();
        }

        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
        public decimal? Discount { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<Discountproduct> Discountproducts { get; set; }
        public virtual ICollection<Discount> Discounts { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<ProductAttachment> ProductAttachments { get; set; }
        public virtual ICollection<ProductColor> ProductColors { get; set; }
    }
}
