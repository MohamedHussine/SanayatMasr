using AutoMapper;
using BusinessLogic.DTOs.SubscriptionPlans;
using DataAccess.Models;

namespace BusinessLogic.Mappers
{
    public class SubscriptionPlanProfile : Profile
    {
        public SubscriptionPlanProfile()
        {
            CreateMap<SubscriptionPlan, GetSubscriptionPlanDto>();

            CreateMap<CreateSubscriptionPlanDto, SubscriptionPlan>();

            CreateMap<UpdateSubscriptionPlanDto, SubscriptionPlan>();
        }
    }
}
