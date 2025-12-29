using AutoMapper;
using BusinessLogic.DTOs.City;
using Entities.Models;

namespace BusinessLogic.Mapping
{
    // Profile خاص بتحويل City <-> DTO
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            // AddCityDto => City
            CreateMap<AddCityDTO, City>();

            // UpdateCityDto => City
            CreateMap<UpdateCityDTO, City>();

            // City => GetAllCityDto
            CreateMap<City, GetAllCityDTO>()
                .ForMember(dest => dest.GovernorateName,
                    opt => opt.MapFrom(src => src.Governorate!.Name))
                .ForMember(dest => dest.GovernorateArabicName,
                    opt => opt.MapFrom(src => src.Governorate!.ArabicName));

            // City => GetCityByIdDto
            CreateMap<City, GetCityByIdDTO>()
                .ForMember(dest => dest.GovernorateName,
                    opt => opt.MapFrom(src => src.Governorate!.Name))
                .ForMember(dest => dest.GovernorateArabicName,
                    opt => opt.MapFrom(src => src.Governorate!.ArabicName));
        }
    }
}
