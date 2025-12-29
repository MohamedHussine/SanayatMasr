using BusinessLogic.DTOs.Reports;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace SanayyMasr.Controllers
{
    [ApiController]
    [Route("api/reports")]
    public class ReportsController : ControllerBase
    {
        private readonly IReportService _service;

        public ReportsController(IReportService service)
        {
            _service = service;
        }

        // =====================================
        // GET /api/reports
        // مفتوح (من غير تسجيل دخول)
        // =====================================
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        // =====================================
        // GET /api/reports/{id}
        // =====================================
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var report = await _service.GetByIdAsync(id);
            return report == null ? NotFound() : Ok(report);
        }

        // =====================================
        // POST /api/reports
        // لازم JWT Token
        // =====================================
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddReportDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // حماية إضافية (حتى لو Authorize موجود)
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);

            if (userIdClaim == null)
                return Unauthorized("User is not authenticated");

            int userId = int.Parse(userIdClaim.Value);

            await _service.AddAsync(userId, dto);

            return Ok("Report submitted successfully");
        }

        // =====================================
        // PUT /api/reports/{id}/resolve
        // Admin فقط
        // =====================================
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}/resolve")]
        public async Task<IActionResult> Resolve(int id)
        {
            await _service.ResolveAsync(id);
            return Ok("Report resolved");
        }
    }
}
