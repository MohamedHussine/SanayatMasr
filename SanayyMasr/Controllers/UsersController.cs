using BusinessLogic.DTOs.Users;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;

namespace SanayyMasr.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;
        private readonly IImageService _imageService;

        public UsersController(
            IUserService service,
            IImageService imageService)
        {
            _service = service;
            _imageService = imageService;
        }
        // =========================
        // SEARCH USERS (Admin)
        // =========================
        [HttpGet("search")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Search(
            [FromServices] IUserSearchService searchService,
            string? name,
            string? email,
            string? phone,
            string? role,
            int? governorateId,
            int? cityId)
        {
            var users = await searchService.SearchAsync(
                name,
                email,
                phone,
                role,
                governorateId,
                cityId);

            return Ok(new
            {
                success = true,
                count = users.Count(),
                data = users
            });
        }

        // =========================
        // GET ALL USERS (Admin)
        // =========================
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            var users = await _service.GetAllAsync();
            return Ok(users);
        }

        // =========================
        // GET USER BY ID (Admin)
        // =========================
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _service.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound(new
                {
                    success = false,
                    message = "User not found"
                });
            }

            return Ok(user);
        }

        // =========================
        // UPDATE USER (Admin)
        // =========================
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int id, UpdateUserDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Invalid data",
                    errors = ModelState
                });
            }

            var adminId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (adminId == null)
            {
                return Unauthorized(new
                {
                    success = false,
                    message = "Invalid token"
                });
            }

            var updated = await _service.UpdateAsync(id, dto, adminId);
            if (!updated)
            {
                return NotFound(new
                {
                    success = false,
                    message = "User not found"
                });
            }

            return Ok(new
            {
                success = true,
                message = "User updated successfully"
            });
        }

        // =========================
        // DELETE USER (Admin)
        // =========================
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var adminId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (adminId == null)
            {
                return Unauthorized(new
                {
                    success = false,
                    message = "Invalid token"
                });
            }

            var deleted = await _service.DeleteAsync(id, adminId);
            if (!deleted)
            {
                return NotFound(new
                {
                    success = false,
                    message = "User not found"
                });
            }

            return Ok(new
            {
                success = true,
                message = "User deleted successfully"
            });
        }

        // =====================================================
        // UPLOAD PROFILE IMAGE (NO EXCEPTIONS)
        // =====================================================
        [Authorize]
        [HttpPost("upload-profile-image")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UploadProfileImage(
            [FromForm] UploadImageDto dto)
        {
            // 1️⃣ Validate file
            if (dto == null || dto.File == null || dto.File.Length == 0)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Image file is required"
                });
            }

            // 2️⃣ Get UserId safely
            var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrWhiteSpace(userIdClaim))
            {
                return Unauthorized(new
                {
                    success = false,
                    message = "Invalid or missing token"
                });
            }

            if (!int.TryParse(userIdClaim, out int userId))
            {
                return Unauthorized(new
                {
                    success = false,
                    message = "Invalid user id in token"
                });
            }

            // 3️⃣ Upload image
            using var stream = dto.File.OpenReadStream();

            var imageUrl = await _imageService.UploadAsync(
                stream,
                dto.File.FileName
            );

            if (string.IsNullOrWhiteSpace(imageUrl))
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Image upload failed"
                });
            }

            // 4️⃣ Update DB
            var updated = await _service.UpdateProfileImageAsync(
                userId,
                imageUrl
            );

            if (!updated)
            {
                return NotFound(new
                {
                    success = false,
                    message = "User not found"
                });
            }

            return Ok(new
            {
                success = true,
                message = "Profile image uploaded successfully",
                imageUrl
            });
        }
    }
}
