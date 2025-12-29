using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Gallery : BaseModel
    {
        public int CraftsmanId { get; set; }
        public Craftsman Craftsman { get; set; } = null!;

        public string MediaUrl { get; set; } = null!;
        public string MediaType { get; set; } = null!; // Image | Video
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
