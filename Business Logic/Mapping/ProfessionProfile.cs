using AutoMapper;
using BusinessLogic.DTOs.Professions;
using Entities.Models;

namespace BusinessLogic.Mapping
{
    // Mapping بين Entity و DTOs
    public class ProfessionProfile : Profile
    {
        public ProfessionProfile()
        {
            // Create
            CreateMap<CreateProfessionDTO, Profession>();

            // Update
            CreateMap<UpdateProfessionDTO, Profession>();

            // Response
            CreateMap<Profession, ProfessionResponseDTO>();
        }
    }
}
