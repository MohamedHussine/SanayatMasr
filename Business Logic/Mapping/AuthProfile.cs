using AutoMapper;
using DataAccess.Models;

public class AuthProfile : Profile
{
    public AuthProfile()
    {
        CreateMap<RegisterRequestDto, User>()
            .ForMember(d => d.PasswordHash, o => o.Ignore())
            .ForMember(d => d.IsActive, o => o.MapFrom(_ => true));
    }
}
