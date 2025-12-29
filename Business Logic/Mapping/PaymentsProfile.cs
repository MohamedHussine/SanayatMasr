using AutoMapper;
using BusinessLogic.DTOs.Payments;
using Entities.Models;

namespace BusinessLogic.Mapping
{
    public class PaymentsProfile : Profile
    {
        public PaymentsProfile()
        {
            // Entity → Response DTO
            CreateMap<Payment, PaymentResponseDTO>()
                .ForMember(
                    dest => dest.CraftsmanId,
                    opt => opt.MapFrom(src => src.Subscription!.CraftsmanId)
                );

            // Create DTO → Entity
            CreateMap<CreatePaymentDTO, Payment>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(_ => "Pending"));
        }
    }
}
