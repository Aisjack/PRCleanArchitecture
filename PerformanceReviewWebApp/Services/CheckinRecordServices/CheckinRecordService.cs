using PerformanceReview.Models.Dtos;
using System.Net.Http.Json;

namespace PerformanceReview.Services.CheckinRecordServices
{
    public class CheckinRecordService : ICheckinRecordService
    {
		private readonly HttpClient _httpClient;
		public CheckinRecordService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task CheckinRecordRegister(CheckinRecordDto request)
        {
            await _httpClient.PostAsJsonAsync<CheckinRecordDto>("checkin", request);
        }
    }
}
