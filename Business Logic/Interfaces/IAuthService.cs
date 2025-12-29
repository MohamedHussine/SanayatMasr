using BusinessLogic.DTOs.Auth;
using Shared.Helpers._ٌResponse;

public interface IAuthService
{
    Task<ServiceResult<AuthResponseDTO>> RegisterAsync(RegisterRequestDTO dto);
    Task<ServiceResult<AuthResponseDTO>> LoginAsync(LoginRequestDTO dto);
    Task<ServiceResult<AuthResponseDTO>> RefreshTokenAsync(string refreshToken);
    Task<ServiceResult<bool>> LogoutAsync(int userId);
}
