using BusinessLogic.DTOs.Craftsmen;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Constants;
using BusinessLogic.Interfaces;

namespace Sanay3yMasr.Controllers
{
    [ApiController]
    [Route("api/craftsmen")]
    public class CraftsmenController : ControllerBase
    {
        private readonly ICraftsmanService _service;
        private readonly IImageService _imageService;

        public CraftsmenController(
            ICraftsmanService service,
            IImageService imageService)
        {
            _service = service;
            _imageService = imageService;
        }


        // =========================
        // SEARCH CRAFTSMEN (Public)
        // =========================
        [HttpGet("search")]
        [AllowAnonymous]
        public async Task<IActionResult> Search(
            [FromServices] ICraftsmanSearchService searchService,
            string? name,
            int? professionId,
            int? governorateId,
            int? cityId,
            decimal? minPrice,
            decimal? maxPrice,
            int? minExperience,
            bool? isVerified)
        {
            var result = await searchService.SearchAsync(
                name,
                professionId,
                governorateId,
                cityId,
                minPrice,
                maxPrice,
                minExperience,
                isVerified);

            return Ok(new
            {
                success = true,
                count = result.Count(),
                data = result
            });
        }


        // ======================
        // GET ALL (Public)
        // ======================
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAllAsync());

        // ======================
        // GET BY ID (Public)
        // ======================
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return result.Success ? Ok(result) : NotFound(result);
        }

        // ======================
        // CREATE (Craftsman only)
        // ======================
        [HttpPost]
        [Authorize(Roles = Roles.Craftsman)]
        public async Task<IActionResult> Create(CreateCraftsmanDTO dto)
            => Ok(await _service.CreateAsync(dto));

        // ======================
        // UPDATE FULL PROFILE (Craftsman)
        // ======================
        [HttpPut("{id}")]
        [Authorize(Roles = Roles.Craftsman)]
        public async Task<IActionResult> Update(
            int id,
            UpdateCraftsmanProfileDTO dto)
        {
            var result = await _service.UpdateAsync(id, dto);
            return result.Success ? Ok(result) : NotFound(result);
        }

        // ======================
        // DELETE (Admin only)
        // ======================
        [HttpDelete("{id}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            return result.Success ? Ok(result) : NotFound(result);
        }

        // =====================================================
        // UPLOAD PROFILE IMAGE (Craftsman نفسه)
        // =====================================================
        [HttpPost("{id}/upload-image")]
        [Authorize(Roles = Roles.Craftsman)]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UploadImage(
            int id,
            [FromForm] UploadImageDto dto)
        {
            if (dto?.File == null || dto.File.Length == 0)
                return BadRequest("Image file is required");

            using var stream = dto.File.OpenReadStream();

            var imageUrl = await _imageService.UploadAsync(
                stream,
                dto.File.FileName);

            if (string.IsNullOrWhiteSpace(imageUrl))
                return BadRequest("Image upload failed");

            var result = await _service.UploadProfileImageAsync(id, imageUrl);
            return result.Success ? Ok(result) : NotFound(result);
        }
    }
}
