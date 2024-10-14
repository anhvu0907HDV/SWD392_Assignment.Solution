using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SWD392_Assignment.Data.Models
{
    public partial class User
    {
        public User()
        {
            Carts = new HashSet<Cart>();
            Feedbacks = new HashSet<Feedback>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? FullName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
