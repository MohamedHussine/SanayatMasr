using AutoMapper;
using BusinessLogic.DTOs.Review;
using BusinessLogic.DTOs.Reviews;
using Entities.Models;

namespace BusinessLogic.Mapping
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<Review, GetReviewDTO>()
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
