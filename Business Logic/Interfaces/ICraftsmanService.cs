using BusinessLogic.DTOs.Craftsmen;
using Shared.Helpers._ٌResponse;

public interface ICraftsmanService
{
    Task<ServiceResult<IEnumerable<GetCraftsmanDTO>>> GetAllAsync();
    Task<ServiceResult<GetCraftsmanDTO>> GetByIdAsync(int id);
    Task<ServiceResult<int>> CreateAsync(CreateCraftsmanDTO dto);

    Task<ServiceResult<bool>> UpdateAsync( int id,UpdateCraftsmanProfileDTO dto);

    Task<ServiceResult<bool>> DeleteAsync(int id);

    Task<ServiceResult<bool>> UploadProfileImageAsync(int craftsmanId,string imageUrl);
}
