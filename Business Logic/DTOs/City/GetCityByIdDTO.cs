namespace BusinessLogic.DTOs.City
{
    // DTO لتفاصيل مدينة واحدة
    public class GetCityByIdDTO 
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string ArabicName { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public int GovernorateId { get; set; }
        public string GovernorateName { get; set; }
        public string GovernorateArabicName { get; set; }
    }
}
