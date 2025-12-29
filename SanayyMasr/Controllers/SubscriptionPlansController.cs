using BusinessLogic.DTOs.SubscriptionPlans;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace SanayyMasr.Controllers
{
    [ApiController]
    [Route("api/subscription-plans")]
    public class SubscriptionPlansController : ControllerBase
    {
        private readonly ISubscriptionPlanService _service;

        public SubscriptionPlansController(ISubscriptionPlanService service)
        {
            _service = service;
        }

        // GET /api/subscription-plans
        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAllAsync());

        // GET /api/subscription-plans/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        // POST (ADMIN ONLY)
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(CreateSubscriptionPlanDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var adminId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            var id = await _service.CreateAsync(dto, adminId);
            return CreatedAtAction(nameof(GetById), new { id }, null);
        }

        // PUT (ADMIN ONLY)
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateSubscriptionPlanDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var adminId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            var updated = await _service.UpdateAsync(id, dto, adminId);
            if (!updated) return NotFound();

            return NoContent();
        }

        // DELETE (ADMIN ONLY)
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var adminId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            var deleted = await _service.DeleteAsync(id, adminId);
            if (!deleted) return NotFound();

            return NoContent();
        }
    }
}
