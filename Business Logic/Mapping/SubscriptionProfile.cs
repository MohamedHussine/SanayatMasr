using AutoMapper;
using BusinessLogic.DTOs.Subscriptions;

namespace BusinessLogic.Mapping
{
    public class SubscriptionProfile : Profile
    {
        public SubscriptionProfile()
        {
            CreateMap<CraftsmanSubscription, SubscriptionResponseDTO>()
                .ForMember(d => d.PlanName,
                    o => o.MapFrom(s => s.Plan!.Name))
                .ForMember(d => d.Price,
                    o => o.MapFrom(s => s.Plan!.Price));
        }
    }
}
