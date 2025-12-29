using BusinessLogic.DTOs.Subscriptions;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SanayyMasr.Controllers
{
    [ApiController]
    [Route("api")]
    [Authorize]
    public class SubscriptionsController : ControllerBase
    {
        private readonly ISubscriptionService _service;

        public SubscriptionsController(ISubscriptionService service)
        {
            _service = service;
        }

        // GET /api/craftsmen/{craftsmanId}/subscriptions
        [HttpGet("craftsmen/{craftsmanId}/subscriptions")]
        public async Task<IActionResult> GetByCraftsman(int craftsmanId)
            => Ok(await _service.GetByCraftsmanAsync(craftsmanId));

        // POST /api/craftsmen/{craftsmanId}/subscriptions
        [HttpPost("craftsmen/{craftsmanId}/subscriptions")]
        public async Task<IActionResult> Create(
            int craftsmanId,
            [FromBody] CreateSubscriptionDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(await _service.CreateAsync(craftsmanId, dto));
        }

        // PUT /api/subscriptions/{id}/cancel
        [Authorize(Roles = "Admin")]
        [HttpPut("subscriptions/{id}/cancel")]
        public async Task<IActionResult> Cancel(int id)
        {
            var result = await _service.CancelAsync(id);
            return result ? Ok("Subscription cancelled") : NotFound();
        }
    }
}
