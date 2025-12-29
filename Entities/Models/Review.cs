namespace Entities.Models
{
    public class Review : BaseModel
    {
        // ممكن يكون null لو Guest أو User اتحذف
        public int? UserId { get; set; }
        public virtual User? Reviewer { get; set; }

        public int CraftsmanId { get; set; }
        public virtual Craftsman Craftsman { get; set; } = null!;

        // من 1 إلى 5
        public int Stars { get; set; }

        public string Comment { get; set; } = null!;

        // Verified من الأدمن
        public bool IsVerified { get; set; }

        // Approved / Rejected
        public bool IsApproved { get; set; }
    }
}
