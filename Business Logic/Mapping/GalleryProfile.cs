using AutoMapper;
using BusinessLogic.DTOs.Gallery;
using Entities.Models;

namespace BusinessLogic.Mapping
{
    // Mapper خاص بالـ Gallery
    public class GalleryProfile : Profile
    {
        public GalleryProfile()
        {
            CreateMap<Gallery, GetGalleryDTO>();
            CreateMap<Gallery, GalleryDetailsDTO>();
            CreateMap<AddGalleryDTO, Gallery>();
        }
    }
}
