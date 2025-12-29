using AutoMapper;
using BusinessLogic.DTOs.SubscriptionPlans;
using Entities.Models;

namespace BusinessLogic.Mappers
{
    public class SubscriptionPlanProfile : Profile
    {
        public SubscriptionPlanProfile()
        {
            CreateMap<SubscriptionPlan, GetSubscriptionPlanDTO>();

            CreateMap<CreateSubscriptionPlanDTO, SubscriptionPlan>();

            CreateMap<UpdateSubscriptionPlanDTO, SubscriptionPlan>();
        }
    }
}
