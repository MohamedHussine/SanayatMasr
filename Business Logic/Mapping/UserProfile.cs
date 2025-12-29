using AutoMapper;
using BusinessLogic.DTOs.Users;
using Entities.Models;

namespace BusinessLogic.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            // ======================
            // User CRUD
            // ======================
            CreateMap<User, GetUserDTO>();
            CreateMap<UpdateUserDTO, User>();

            // ======================
            // User Search Result
            // ======================
            CreateMap<User, UserSearchResultDTO>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.Email))
                .ForMember(d => d.FullName, o => o.MapFrom(s => s.FullName))
                .ForMember(d => d.Phone, o => o.MapFrom(s => s.Phone))
                .ForMember(d => d.Role, o => o.MapFrom(s => s.Role))
                .ForMember(d => d.IsActive, o => o.MapFrom(s => s.IsActive))
                .ForMember(d => d.ProfileImage, o => o.MapFrom(s => s.ProfileImage))
                .ForMember(d => d.GovernorateName,
                    o => o.MapFrom(s =>
                        s.Governorate != null ? s.Governorate.Name : null))
                .ForMember(d => d.CityName,
                    o => o.MapFrom(s =>
                        s.City != null ? s.City.Name : null));

        }
    }
}
