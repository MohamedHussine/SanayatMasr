using BusinessLogic.DTOs.Reviews;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace SanayyMasr.Controllers
{
    [ApiController]
    [Route("api")]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewService _service;

        public ReviewsController(IReviewService service)
        {
            _service = service;
        }

        
        //[Authorize(Roles = "Admin")]
        [HttpGet("reviews")]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAllAsync());

        // GET reviews by craftsman
        [HttpGet("craftsmen/{craftsmanId}/reviews")]
        public async Task<IActionResult> GetByCraftsman(int craftsmanId)
            => Ok(await _service.GetByCraftsmanAsync(craftsmanId));

        // GET average rating
        [HttpGet("craftsmen/{craftsmanId}/reviews/average")]
        public async Task<IActionResult> Average(int craftsmanId)
            => Ok(await _service.GetAverageAsync(craftsmanId));

        // POST review
        [Authorize]
        [HttpPost("craftsmen/{craftsmanId}/reviews")]
        public async Task<IActionResult> Create(
            int craftsmanId,
            AddReviewDTO dto)
        {
            var userId = int.Parse(
                User.FindFirstValue(ClaimTypes.NameIdentifier)!
            );

            await _service.AddAsync(craftsmanId, userId, dto);
            return Ok();
        }

        // PUT verify
        [Authorize(Roles = "Admin")]
        [HttpPut("reviews/{id}/verify")]
        public async Task<IActionResult> Verify(int id)
        {
            await _service.VerifyAsync(id);
            return Ok();
        }

        // DELETE review
        [Authorize(Roles = "Admin")]
        [HttpDelete("reviews/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}
