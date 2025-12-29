using BusinessLogic.DTOs.Auth;
using Entities.Models;


namespace BusinessLogic.Interfaces
{

    public interface ITokenService
    {
        // Generate access + refresh tokens
        Task<AuthResponseDTO> GenerateAsync(User user);

        // Refresh token (null if invalid / expired)
        Task<AuthResponseDTO?> RefreshAsync(string refreshToken);
    }
}
