using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.City
{
    // DTO لتعديل بيانات المدينة
    public class UpdateCityDTO
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string ArabicName { get; set; }

        [Range(-90, 90)]
        public decimal Latitude { get; set; }

        [Range(-180, 180)]
        public decimal Longitude { get; set; }
    }
}
