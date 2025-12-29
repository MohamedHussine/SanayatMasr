using AutoMapper;
using BusinessLogic.DTOs.Reports;
using Entities.Models;

namespace BusinessLogic.Mappers
{
    public class ReportProfile : Profile
    {
        public ReportProfile()
        {
            // DTO -> Entity
            CreateMap<AddReportDTO, Report>();

            // Entity -> List DTO
            CreateMap<Report, GetAllReportDTO>()
                .ForMember(d => d.ReporterName,
                    o => o.MapFrom(s => s.Reporter.FullName))
                .ForMember(d => d.CraftsmanName,
                    o => o.MapFrom(s => s.ReportedCraftsman.User.FullName));

            // Entity -> Details DTO
            CreateMap<Report, GetReportByIdDTO>();
        }
    }
}
