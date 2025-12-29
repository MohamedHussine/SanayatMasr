using System;

namespace BusinessLogic.DTOs.Reports
{
    // عرض كل البلاغات
    public class GetAllReportDTO
    {
        public int Id { get; set; }

        public string Message { get; set; }
        public string Status { get; set; }
        public bool IsResolved { get; set; }

        public string ReporterName { get; set; }
        public string CraftsmanName { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
