using System;

namespace BusinessLogic.DTOs.Reports
{
    // تفاصيل بلاغ واحد
    public class GetReportByIdDTO
    {
        public int Id { get; set; }

        public int ReporterUserId { get; set; }
        public int CraftsmanId { get; set; }

        public string Message { get; set; }
        public string Status { get; set; }
        public bool IsResolved { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
