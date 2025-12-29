using AutoMapper;
using BusinessLogic.DTOs.Reports;
using DataAccess.Models;

namespace BusinessLogic.Mappers
{
    public class ReportProfile : Profile
    {
        public ReportProfile()
        {
            // DTO -> Entity
            CreateMap<AddReportDto, Report>();

            // Entity -> List DTO
            CreateMap<Report, GetAllReportDto>()
                .ForMember(d => d.ReporterName,
                    o => o.MapFrom(s => s.Reporter.FullName))
                .ForMember(d => d.CraftsmanName,
                    o => o.MapFrom(s => s.ReportedCraftsman.User.FullName));

            // Entity -> Details DTO
            CreateMap<Report, GetReportByIdDto>();
        }
    }
}
