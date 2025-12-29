
using BusinessLogic.DTOs.Skills;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace SanayyMasr.Controllers
{
    [ApiController]
    [Route("api/skills")]
    [Authorize]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillService _skillService;

        public SkillsController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        // GET /api/skills
        [HttpGet]
        [AllowAnonymous] // 👀 متاح للكل
        public async Task<IActionResult> GetAll()
        {
            var result = await _skillService.GetAllAsync();
            return Ok(result);
        }

        // GET /api/skills/{id}
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _skillService.GetByIdAsync(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        // POST /api/skills
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(AddSkillDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var userName = User.FindFirstValue(ClaimTypes.Name);

            await _skillService.AddAsync(dto, userName!);
            return Ok();
        }

        // PUT /api/skills/{id}
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int id, UpdateSkillDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var userName = User.FindFirstValue(ClaimTypes.Name);

            await _skillService.UpdateAsync(id, dto, userName!);
            return Ok();
        }

        // DELETE /api/skills/{id}
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            await _skillService.DeleteAsync(id);
            return Ok();
        }
    }
}
