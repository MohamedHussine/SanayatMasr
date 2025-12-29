using BusinessLogic.DTOs.Craftsmen;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SanayyMasr.Controllers
{
    [ApiController]
    [Route("api/craftsmen")]
    [Authorize]
    public class CraftsmanCitiesController : ControllerBase
    {
        private readonly ICraftsmanCityService _service;

        public CraftsmanCitiesController(ICraftsmanCityService service)
        {
            _service = service;
        }

        // ================= GET =================
        // GET /api/craftsmen/{craftsmanId}/cities
        [HttpGet("{craftsmanId}/cities")]
        public async Task<IActionResult> Get(int craftsmanId)
            => Ok(await _service.GetByCraftsmanAsync(craftsmanId));

        // ================= POST =================
        // POST /api/craftsmen/{craftsmanId}/cities
        [Authorize(Roles = "Craftsman")]
        [HttpPost("{craftsmanId}/cities")]
        public async Task<IActionResult> Create(
            int craftsmanId,
            [FromBody] CreateCraftsmanCityDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _service.AddAsync(craftsmanId, dto);
            return Ok("City added successfully");
        }

        // ================= SET PRIMARY =================
        // PUT /api/craftsmen/{craftsmanId}/cities/{cityId}/set-primary
        [Authorize(Roles = "Craftsman")]
        [HttpPut("{craftsmanId}/cities/{cityId}/set-primary")]
        public async Task<IActionResult> SetPrimary(int craftsmanId, int cityId)
        {
            await _service.SetPrimaryAsync(craftsmanId, cityId);
            return Ok("Primary city updated");
        }

        // ================= DELETE =================
        // DELETE /api/craftsmen/{craftsmanId}/cities/{cityId}
        [Authorize(Roles = "Craftsman,Admin")] // ✅ Craftsman أو Admin
        [HttpDelete("{craftsmanId}/cities/{cityId}")]
        public async Task<IActionResult> Delete(int craftsmanId, int cityId)
        {
            await _service.DeleteAsync(craftsmanId, cityId);
            return Ok("City deleted");
        }
    }
}
