using AutoMapper;
using BusinessLogic.DTOs.Professions;
using DataAccess.Models;

namespace BusinessLogic.Mappers
{
    // Mapping بين Entity و DTOs
    public class ProfessionProfile : Profile
    {
        public ProfessionProfile()
        {
            // Create
            CreateMap<CreateProfessionDto, Profession>();

            // Update
            CreateMap<UpdateProfessionDto, Profession>();

            // Response
            CreateMap<Profession, ProfessionResponseDto>();
        }
    }
}
