using System;
using System.Collections.Generic;

namespace SWD392_Assignment.Data.Models
{
    public partial class FeedbackAttachment
    {
        public int Id { get; set; }
        public string? FileName { get; set; }
        public string? Url { get; set; }
        public string? MediaType { get; set; }
        public int? FeedbackId { get; set; }

        public virtual Feedback? Feedback { get; set; }
    }
}
