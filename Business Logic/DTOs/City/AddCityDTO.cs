using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.City
{
    // DTO خاص بإنشاء مدينة جديدة
    public class AddCityDTO
    {
        // Id المحافظة (إجباري)
        [Required]
        public int GovernorateId { get; set; }

        // اسم المدينة إنجليزي
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // اسم المدينة عربي
        [Required]
        [StringLength(100)]
        public string ArabicName { get; set; }

        // خط العرض
        [Range(-90, 90)]
        public decimal Latitude { get; set; }

        // خط الطول
        [Range(-180, 180)]
        public decimal Longitude { get; set; }
    }
}
