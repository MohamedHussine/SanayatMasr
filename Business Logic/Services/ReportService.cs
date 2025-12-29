using AutoMapper;
using BusinessLogic.DTOs.Reports;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class ReportService : IReportService
    {
        private readonly IGeneralRepository<Report> _repo;
        private readonly IMapper _mapper;

        public ReportService(IGeneralRepository<Report> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // جلب كل البلاغات
        public async Task<IEnumerable<GetAllReportDTO>> GetAllAsync()
        {
            var reports = await _repo.GetAll()
                .Include(r => r.Reporter)
                .Include(r => r.ReportedCraftsman)
                    .ThenInclude(c => c.User) // مهم جدًا
                .ToListAsync();

            return _mapper.Map<IEnumerable<GetAllReportDTO>>(reports);
        }

        // بلاغ واحد
        public async Task<GetReportByIdDTO?> GetByIdAsync(int id)
        {
            var report = await _repo.GetAll()
                .FirstOrDefaultAsync(r => r.Id == id);

            return report == null ? null : _mapper.Map<GetReportByIdDTO>(report);
        }

        // إضافة بلاغ
        public async Task AddAsync(int reporterUserId, AddReportDTO dto)
        {
            var report = _mapper.Map<Report>(dto);

            report.ReporterUserId = reporterUserId;
            report.Status = "Pending";
            report.IsResolved = false;
            report.CreatedAt = DateTime.UtcNow;

            await _repo.Add(report);
        }

        // حل البلاغ (Admin)
        public async Task ResolveAsync(int id)
        {
            var report = await _repo.GetByIDWithTracking(id);
            if (report == null)
                throw new KeyNotFoundException("Report not found");

            report.Status = "Resolved";
            report.IsResolved = true;
            report.UpdatedAt = DateTime.UtcNow;

            await _repo.Update(report);
        }
    }
}
