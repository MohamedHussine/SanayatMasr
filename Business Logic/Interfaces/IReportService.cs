using BusinessLogic.DTOs.Reports;

namespace BusinessLogic.Interfaces
{
    public interface IReportService
    {
        Task<IEnumerable<GetAllReportDTO>> GetAllAsync();
        Task<GetReportByIdDTO?> GetByIdAsync(int id);

        Task AddAsync(int reporterUserId, AddReportDTO dto);
        Task ResolveAsync(int id);
    }
}
