using AutoMapper;
using BusinessLogic.DTOs.Gallery;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    // Service يحتوي على منطق العمل الخاص بالجاليري
    public class GalleryService : IGalleryService
    {
        private readonly IGeneralRepository<Gallery> _galleryRepo;
        private readonly IMapper _mapper;

        public GalleryService(
            IGeneralRepository<Gallery> galleryRepo,
            IMapper mapper)
        {
            _galleryRepo = galleryRepo;
            _mapper = mapper;
        }

        // جلب كل صور/فيديوهات حرفي معين
        public async Task<IEnumerable<GetGalleryDTO>> GetByCraftsmanId(int craftsmanId)
        {
            var gallery = await _galleryRepo.GetAll()
                .Where(g => g.CraftsmanId == craftsmanId)
                .ToListAsync();

            return _mapper.Map<IEnumerable<GetGalleryDTO>>(gallery);
        }

        // جلب عنصر واحد
        public async Task<GalleryDetailsDTO?> GetById(int galleryId)
        {
            var item = await _galleryRepo.GetByID(galleryId);
            if (item == null) return null;

            return _mapper.Map<GalleryDetailsDTO>(item);
        }

        // إضافة صورة/فيديو
        public async Task<bool> Add(int craftsmanId, AddGalleryDTO dto)
        {
            var entity = _mapper.Map<Gallery>(dto);
            entity.CraftsmanId = craftsmanId;

            await _galleryRepo.Add(entity);
            return true;
        }

        // حذف (Soft Delete)
        public async Task<bool> Delete(int galleryId)
        {
            await _galleryRepo.Delete(galleryId);
            return true;
        }
    }
}
