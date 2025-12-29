using BusinessLogic.DTOs.Payments;

namespace BusinessLogic.Interfaces
{
    public interface IPaymentService
    {
        Task<IEnumerable<PaymentResponseDTO>> GetAllAsync();
        Task<PaymentResponseDTO?> GetByIdAsync(int id);
        Task<IEnumerable<PaymentResponseDTO>> GetByCraftsmanAsync(int craftsmanId);
        Task<PaymentResponseDTO> CreateAsync(CreatePaymentDTO dto);
    }
}
