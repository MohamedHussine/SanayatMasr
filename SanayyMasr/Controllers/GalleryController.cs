using BusinessLogic.DTOs.Gallery;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SanayyMasr.Controllers
{
    [ApiController]
    [Route("api")]
    public class GalleryController : ControllerBase
    {
        private readonly IGalleryService _galleryService;

        public GalleryController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        // ===========================
        // GET → مفتوح للجميع
        // ===========================
        [HttpGet("craftsmen/{craftsmanId}/gallery")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByCraftsman(int craftsmanId)
        {
            var result = await _galleryService.GetByCraftsmanId(craftsmanId);
            return Ok(result);
        }

        // ===========================
        // POST → Craftsman أو Admin
        // ===========================
        [Authorize(Policy = "CraftsmanOrAdmin")]
        [HttpPost("craftsmen/{craftsmanId}/gallery")]
        public async Task<IActionResult> Add(
            int craftsmanId,
            [FromBody] AddGalleryDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _galleryService.Add(craftsmanId, dto);
            return Ok(new { message = "Gallery item added successfully" });
        }

        // ===========================
        // DELETE → Craftsman أو Admin
        // ===========================
        [Authorize(Policy = "CraftsmanOrAdmin")]
        [HttpDelete("gallery/{galleryId}")]
        public async Task<IActionResult> Delete(int galleryId)
        {
            await _galleryService.Delete(galleryId);
            return Ok(new { message = "Gallery item deleted successfully" });
        }
    }
}
