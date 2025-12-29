namespace Entities.Models

{
    // كيان البلاغ
    public class Report : BaseModel
    {
        // المستخدم اللي عمل البلاغ
        public int ReporterUserId { get; set; }
        public User Reporter { get; set; }

        // الصنايعي المبلغ عنه
        public int CraftsmanId { get; set; }
        public Craftsman ReportedCraftsman { get; set; }

        // نص الشكوى
        public string Message { get; set; }

        // Pending | Resolved
        public string Status { get; set; } = "Pending";

        // هل تم الحل
        public bool IsResolved { get; set; } = false;
    }
}
