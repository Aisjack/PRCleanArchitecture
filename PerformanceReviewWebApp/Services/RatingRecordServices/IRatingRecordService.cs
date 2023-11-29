using PerformanceReview.Models.Dtos;

namespace PerformanceReview.Services.RatingRecordServices
{
    public interface IRatingRecordService
    {
        Task RatingRecordRegister(RatingRecordDto request);
    }
}
