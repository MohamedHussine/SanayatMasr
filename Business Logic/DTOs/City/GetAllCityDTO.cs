namespace BusinessLogic.DTOs.City
{
    // DTO لعرض المدن في القايمة
    public class GetAllCityDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string ArabicName { get; set; }

        public string GovernorateName { get; set; }
        public string GovernorateArabicName { get; set; }
    }
}
