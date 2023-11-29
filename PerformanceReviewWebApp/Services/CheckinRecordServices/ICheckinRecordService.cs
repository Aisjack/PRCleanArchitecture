using PerformanceReview.Models.Dtos;

namespace PerformanceReview.Services.CheckinRecordServices
{
    public interface ICheckinRecordService
    {
        Task CheckinRecordRegister(CheckinRecordDto request);
    }
}
