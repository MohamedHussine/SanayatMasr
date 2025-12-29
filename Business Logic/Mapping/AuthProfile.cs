using AutoMapper;
using Entities.Models;

public class AuthProfile : Profile
{
    public AuthProfile()
    {
        CreateMap<RegisterRequestDTO, User>()
            .ForMember(d => d.PasswordHash, o => o.Ignore())
            .ForMember(d => d.IsActive, o => o.MapFrom(_ => true));
    }
}
