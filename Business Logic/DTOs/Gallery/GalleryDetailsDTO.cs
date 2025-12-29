namespace BusinessLogic.DTOs.Gallery
{
    // DTO لتفاصيل صورة واحدة
    public class GalleryDetailsDTO
    {
        public int Id { get; set; }
        public string MediaUrl { get; set; } = null!;
        public string MediaType { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
