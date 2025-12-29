using AutoMapper;
using BusinessLogic.DTOs.Payments;
using DataAccess.Models;

namespace BusinessLogic.Mappers
{
    public class PaymentsProfile : Profile
    {
        public PaymentsProfile()
        {
            // Entity → Response DTO
            CreateMap<Payment, PaymentResponseDto>()
                .ForMember(
                    dest => dest.CraftsmanId,
                    opt => opt.MapFrom(src => src.Subscription!.CraftsmanId)
                );

            // Create DTO → Entity
            CreateMap<CreatePaymentDto, Payment>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(_ => "Pending"));
        }
    }
}
