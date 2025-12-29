using AutoMapper;
using BusinessLogic.DTOs.Gallery;
using DataAccess.Models;

namespace BusinessLogic.Mappers
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
