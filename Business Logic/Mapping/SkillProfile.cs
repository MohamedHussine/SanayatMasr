using AutoMapper;

using BusinessLogic.DTOs.Skills;
using DataAccess.Models;

namespace BusinessLogic.Mappers
{
    public class SkillProfile : Profile
    {
        public SkillProfile()
        {
            // Add → Entity
            CreateMap<AddSkillDto, Skill>();

            // Update → Entity
            CreateMap<UpdateSkillDto, Skill>();

            // Entity → Get
            CreateMap<Skill, GetSkillDto>();
        }
    }
}
