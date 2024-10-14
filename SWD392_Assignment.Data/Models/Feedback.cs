using System;
using System.Collections.Generic;

namespace SWD392_Assignment.Data.Models
{
    public partial class Feedback
    {
        public Feedback()
        {
            FeedbackAttachments = new HashSet<FeedbackAttachment>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ProductId { get; set; }
        public int? Star { get; set; }
        public string? Comment { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Product? Product { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<FeedbackAttachment> FeedbackAttachments { get; set; }
    }
}
