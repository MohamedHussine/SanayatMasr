using AutoMapper;
using BusinessLogic.DTOs.Craftsmen;
using DataAccess.Models;
using System.Linq;

public class CraftsmanProfile : Profile
{
    public CraftsmanProfile()
    {
        // ======================
        // Create / Update
        // ======================
        CreateMap<CreateCraftsmanDto, Craftsman>();
        CreateMap<UpdateCraftsmanProfileDto, Craftsman>();

        // ======================
        // Entity -> DTO
        // ======================
        CreateMap<Craftsman, GetCraftsmanDto>()
            // ----------------------
            // User info
            // ----------------------
            .ForMember(d => d.FullName,
                o => o.MapFrom(s => s.User != null
                    ? s.User.FullName
                    : string.Empty))

            .ForMember(d => d.Phone,
                o => o.MapFrom(s => s.User != null
                    ? s.User.Phone
                    : null))

            // ----------------------
            // ✅ Profile Image (from Gallery)
            // ----------------------
            .ForMember(d => d.ProfileImageUrl,
                o => o.MapFrom(s =>
                    s.GalleryImages != null
                        ? s.GalleryImages
                            .Where(g =>
                                g.MediaType == "Profile" &&
                                !g.IsDeleted)
                            .OrderByDescending(g => g.CreatedAt)
                            .Select(g => g.MediaUrl)
                            .FirstOrDefault()
                        : null
                ))

            // ----------------------
            // Location
            // ----------------------
            .ForMember(d => d.GovernorateName,
                o => o.MapFrom(s =>
                    s.User != null && s.User.Governorate != null
                        ? s.User.Governorate.Name
                        : null))

            .ForMember(d => d.CityName,
                o => o.MapFrom(s =>
                    s.User != null && s.User.City != null
                        ? s.User.City.Name
                        : null));


        // ======================
        // SEARCH RESULT
        // ======================
        CreateMap<Craftsman, CraftsmanSearchResultDto>()
            .ForMember(d => d.FullName,
                o => o.MapFrom(s =>
                    s.User != null ? s.User.FullName : string.Empty))
            .ForMember(d => d.Phone,
                o => o.MapFrom(s =>
                    s.User != null ? s.User.Phone : null))
            .ForMember(d => d.ProfileImageUrl,
                o => o.MapFrom(s =>
                    s.GalleryImages != null
                        ? s.GalleryImages
                            .Where(g => g.MediaType == "Profile" && !g.IsDeleted)
                            .OrderByDescending(g => g.CreatedAt)
                            .Select(g => g.MediaUrl)
                            .FirstOrDefault()
                        : null))
            .ForMember(d => d.GovernorateName,
                o => o.MapFrom(s =>
                    s.User != null && s.User.Governorate != null
                        ? s.User.Governorate.Name
                        : null))
            .ForMember(d => d.CityName,
                o => o.MapFrom(s =>
                    s.User != null && s.User.City != null
                        ? s.User.City.Name
                        : null))
            .ForMember(d => d.ProfessionName,
                o => o.MapFrom(s =>
                    s.Profession != null ? s.Profession.Name : null));

    }
}
