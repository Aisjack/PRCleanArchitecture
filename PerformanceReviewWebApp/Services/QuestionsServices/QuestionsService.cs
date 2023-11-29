using PerformanceReview.Models.Entities;
using System.Net.Http.Json;

namespace PerformanceReview.Services.QuestionsServices
{
    public class QuestionsService : IQuestionsService
    {
        private readonly HttpClient _httpClient;
		public QuestionsService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public static List<string> _questions = new List<string>()
        {
            "Question 1: Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.",
            "Question 2: Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.",
            "Question 3: Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.",
            "Question 4: Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.",
            "Question 5: Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor."
        };

        public async Task<List<Question>?> GetAllQuestionApi()
        {
            return await _httpClient.GetFromJsonAsync<List<Question>?>("question");
        }

        public List<string> GetQuestions()
        {
            return _questions;
        }
    }
}
