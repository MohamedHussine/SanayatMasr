using BusinessLogic.DTOs.Gallery;

namespace BusinessLogic.Interfaces
{
    // Interface خاص بجميع عمليات الجاليري
    public interface IGalleryService
    {
        Task<IEnumerable<GetGalleryDTO>> GetByCraftsmanId(int craftsmanId);
        Task<GalleryDetailsDTO?> GetById(int galleryId);
        Task<bool> Add(int craftsmanId, AddGalleryDTO dto);
        Task<bool> Delete(int galleryId);
    }
}
