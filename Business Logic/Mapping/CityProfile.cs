using AutoMapper;
using BusinessLogic.DTOs.City;
using DataAccess.Models;

namespace BusinessLogic.Mappers
{
    // Profile خاص بتحويل City <-> DTO
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            // AddCityDto => City
            CreateMap<AddCityDto, City>();

            // UpdateCityDto => City
            CreateMap<UpdateCityDto, City>();

            // City => GetAllCityDto
            CreateMap<City, GetAllCityDto>()
                .ForMember(dest => dest.GovernorateName,
                    opt => opt.MapFrom(src => src.Governorate!.Name))
                .ForMember(dest => dest.GovernorateArabicName,
                    opt => opt.MapFrom(src => src.Governorate!.ArabicName));

            // City => GetCityByIdDto
            CreateMap<City, GetCityByIdDto>()
                .ForMember(dest => dest.GovernorateName,
                    opt => opt.MapFrom(src => src.Governorate!.Name))
                .ForMember(dest => dest.GovernorateArabicName,
                    opt => opt.MapFrom(src => src.Governorate!.ArabicName));
        }
    }
}
