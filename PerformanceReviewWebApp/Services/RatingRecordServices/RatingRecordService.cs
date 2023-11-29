using PerformanceReview.Models.Dtos;
using System.Net.Http.Json;

namespace PerformanceReview.Services.RatingRecordServices
{
    public class RatingRecordService : IRatingRecordService
    {
		private readonly HttpClient _httpClient;
		public RatingRecordService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task RatingRecordRegister(RatingRecordDto request)
        {
            await _httpClient.PostAsJsonAsync<RatingRecordDto>("rating", request);
        }
    }
}
