using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public class Profession : BaseModel
    {
        public string Name { get; set; } = null!;
        public string ArabicName { get; set; } = null!;
        public string? Description { get; set; }

        // Navigation
        public virtual ICollection<Craftsman> Craftsmen { get; set; } = new HashSet<Craftsman>();
    }
}
