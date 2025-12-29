using AutoMapper;
using BusinessLogic.DTOs.Subscriptions;
using DataAccess.Models;

namespace BusinessLogic.Mappers
{
    public class SubscriptionProfile : Profile
    {
        public SubscriptionProfile()
        {
            CreateMap<CraftsmanSubscription, SubscriptionResponseDto>()
                .ForMember(d => d.PlanName,
                    o => o.MapFrom(s => s.Plan!.Name))
                .ForMember(d => d.Price,
                    o => o.MapFrom(s => s.Plan!.Price));
        }
    }
}
