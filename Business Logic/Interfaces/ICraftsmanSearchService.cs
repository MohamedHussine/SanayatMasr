using BusinessLogic.DTOs.Craftsmen;

namespace BusinessLogic.Interfaces
{
    public interface ICraftsmanSearchService
    {
        Task<IEnumerable<CraftsmanSearchResultDTO>> SearchAsync(
            string? name,
            int? professionId,
            int? governorateId,
            int? cityId,
            decimal? minPrice,
            decimal? maxPrice,
            int? minExperience,
            bool? isVerified
        );
    }
}
