using BusinessLogic.DTOs.Craftsmen;

public interface ICraftsmanCityService
{
    Task<IEnumerable<CraftsmanCityResponseDTO>> GetByCraftsmanAsync(int craftsmanId);
    Task AddAsync(int craftsmanId, CreateCraftsmanCityDTO dto);
    Task SetPrimaryAsync(int craftsmanId, int cityId);
    Task DeleteAsync(int craftsmanId, int cityId);
}
