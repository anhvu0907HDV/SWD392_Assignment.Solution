using System;
using System.Collections.Generic;

namespace SWD392_Assignment.Data.Models
{
    public partial class ProductAttachment
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string? FileName { get; set; }
        public string? MediaType { get; set; }
        public bool? IsThumbnail { get; set; }

        public virtual Product? Product { get; set; }
    }
}
