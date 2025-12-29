using AutoMapper;

using BusinessLogic.DTOs.Skills;
using Entities.Models;

namespace BusinessLogic.Mapping
{
    public class SkillProfile : Profile
    {
        public SkillProfile()
        {
            // Add → Entity
            CreateMap<AddSkillDTO, Skill>();

            // Update → Entity
            CreateMap<UpdateSkillDTO, Skill>();

            // Entity → Get
            CreateMap<Skill, GetSkillDTO>();
        }
    }
}
