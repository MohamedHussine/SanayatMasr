using AutoMapper;
using BusinessLogic.DTOs.Review;
using BusinessLogic.DTOs.Reviews;
using DataAccess.Models;

namespace BusinessLogic.Mappers
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<Review, GetReviewDto>()
                .ForMember(
                    dest => dest.ReviewerName,
                    opt => opt.MapFrom(src =>
                        src.Reviewer != null
                            ? src.Reviewer.FullName
                            : "Guest"
                    )
                );
        }
    }
}
