using BusinessLogic.DTOs.City;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SanayyMasr.Controllers
{
    [ApiController]
    [Route("api")]
    public class CityController : ControllerBase
    {
        private readonly ICityService _service;

        public CityController(ICityService service)
        {
            _service = service;
        }

        [HttpGet("cities")]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAllAsync());

        [HttpGet("cities/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var city = await _service.GetByIdAsync(id);
            return city == null ? NotFound() : Ok(city);
        }

        [HttpGet("governorates/{govId}/cities")]
        public async Task<IActionResult> GetByGovernorate(int govId)
            => Ok(await _service.GetByGovernorateAsync(govId));

        [Authorize(Roles = "Admin")]
        [HttpPost("cities")]
        public async Task<IActionResult> Create(AddCityDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _service.AddAsync(dto);
            return Ok();
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("cities/{id}")]
        public async Task<IActionResult> Update(int id, UpdateCityDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _service.UpdateAsync(id, dto);
            return Ok();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("cities/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}
