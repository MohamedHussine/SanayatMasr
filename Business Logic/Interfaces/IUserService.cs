using BusinessLogic.DTOs.Users;

public interface IUserService
{
    Task<IEnumerable<GetUserDTO>> GetAllAsync();
    Task<GetUserDTO?> GetByIdAsync(int id);

    Task<bool> UpdateAsync(int id, UpdateUserDTO dto, string adminId);
    Task<bool> DeleteAsync(int id, string adminId);
    Task<bool> UpdateProfileImageAsync(int userId, string imageUrl);
}
