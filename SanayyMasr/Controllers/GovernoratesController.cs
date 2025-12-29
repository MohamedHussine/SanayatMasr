using BusinessLogic.DTOs.Governorates;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SanayyMasr.Controllers
{
    [ApiController]
    [Route("api/governorates")]
    public class GovernoratesController : ControllerBase
    {
        private readonly IGovernorateService _service;

        public GovernoratesController(IGovernorateService service)
        {
            _service = service;
        }

        // ================= GET ALL =================
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAllAsync());

        // ================= GET BY ID =================
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        // ================= CREATE =================
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(AddGovernorateDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _service.AddAsync(dto);
            return Ok("Governorate created");
        }

        // ================= UPDATE =================
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateGovernorateDTO dto)
        {
            await _service.UpdateAsync(id, dto);
            return Ok("Governorate updated");
        }

        // ================= DELETE =================
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok("Governorate deleted");
        }
    }
}
