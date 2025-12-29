
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SanayyMasr.Controllers
{
    [ApiController]
    [Route("api/craftsmen")]
    [Authorize]
    public class CraftsmanSkillsController : ControllerBase
    {
        private readonly ICraftsmanSkillService _service;

        public CraftsmanSkillsController(ICraftsmanSkillService service)
        {
            _service = service;
        }

        // ================= GET =================
        [HttpGet("{craftsmanId}/skills")]
        public async Task<IActionResult> Get(int craftsmanId)
            => Ok(await _service.GetByCraftsmanAsync(craftsmanId));

        // ================= POST =================
        [HttpPost("{craftsmanId}/skills")]
        [Authorize(Roles = "Craftsman")]
        public async Task<IActionResult> Create(
            int craftsmanId,
            [FromBody] CreateCraftsmanSkillDTO dto)
        {
            await _service.AddAsync(craftsmanId, dto);
            return Ok();
        }

        // ================= PUT =================
        [HttpPut("{craftsmanId}/skills/{skillId}")]
        [Authorize(Roles = "Craftsman")]
        public async Task<IActionResult> Update(
            int craftsmanId,
            int skillId,
            [FromBody] UpdateCraftsmanSkillDTO dto)
        {
            await _service.UpdateAsync(craftsmanId, skillId, dto);
            return Ok();
        }

        // ================= DELETE =================
        [HttpDelete("{craftsmanId}/skills/{skillId}")]
        [Authorize(Roles = "Craftsman,Admin")]
        public async Task<IActionResult> Delete(int craftsmanId, int skillId)
        {
            await _service.DeleteAsync(craftsmanId, skillId);
            return Ok();
        }
    }
}
