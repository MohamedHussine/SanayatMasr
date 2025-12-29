using BusinessLogic.DTOs.Users;

namespace BusinessLogic.Interfaces
{
    public interface IUserSearchService
    {
        Task<IEnumerable<UserSearchResultDTO>> SearchAsync(
            string? name,
            string? email,
            string? phone,
            string? role,
            int? governorateId,
            int? cityId);
    }
}
