using AutoMapper;
using BusinessLogic.DTOs.Governorates;
using Entities.Models;

namespace BusinessLogic.Mapping
{
    public class GovernorateProfile : Profile
    {
        public GovernorateProfile()
        {
            CreateMap<Governorate, GovernorateListDTO>();
            CreateMap<Governorate, GovernorateDetailsDTO>();

            CreateMap<AddGovernorateDTO, Governorate>();
            CreateMap<UpdateGovernorateDTO, Governorate>();
        }
    }
}
