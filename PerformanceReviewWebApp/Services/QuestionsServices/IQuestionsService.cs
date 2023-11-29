using PerformanceReview.Models.Entities;

namespace PerformanceReview.Services.QuestionsServices
{
    public interface IQuestionsService
    {
        List<string> GetQuestions();
        Task<List<Question>?> GetAllQuestionApi();
    }
}
