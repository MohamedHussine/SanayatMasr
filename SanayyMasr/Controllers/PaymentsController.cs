using BusinessLogic.DTOs.Payments;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SanayyMasr.Controllers
{
    [ApiController]
    [Route("api")]
    [Authorize] // 👈 أي Request لازم يكون عامل Login
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        // =========================
        // GET /api/payments
        // Admin فقط
        // =========================
        [Authorize(Roles = "Admin")]
        [HttpGet("payments")]
        public async Task<IActionResult> GetAll()
            => Ok(await _paymentService.GetAllAsync());

        // =========================
        // GET /api/payments/{id}
        // Admin فقط
        // =========================
        [Authorize(Roles = "Admin")]
        [HttpGet("payments/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _paymentService.GetByIdAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        // =========================
        // GET /api/craftsmen/{craftsmanId}/payments
        // Admin + Craftsman
        // =========================
        [Authorize(Roles = "Admin,Craftsman")]
        [HttpGet("craftsmen/{craftsmanId}/payments")]
        public async Task<IActionResult> GetByCraftsman(int craftsmanId)
            => Ok(await _paymentService.GetByCraftsmanAsync(craftsmanId));

        // =========================
        // POST /api/payments
        // أي User عامل Login
        // =========================
        [HttpPost("payments")]
        public async Task<IActionResult> Create(CreatePaymentDTO dto)
            => Ok(await _paymentService.CreateAsync(dto));
    }
}
