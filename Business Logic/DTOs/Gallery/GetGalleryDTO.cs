namespace BusinessLogic.DTOs.Gallery
{
    // DTO لعرض الصور في الجاليري
    public class GetGalleryDTO
    {
        public int Id { get; set; }
        public string MediaUrl { get; set; } = null!;
        public string MediaType { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
