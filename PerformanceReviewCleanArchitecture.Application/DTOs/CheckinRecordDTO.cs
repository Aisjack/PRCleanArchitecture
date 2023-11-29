namespace PerformanceReviewCleanArchitecture.Application.DTOs;

public class CheckinRecordDTO
{
	public int QuestionId { get; set; }
	public int UserId { get; set; }
	public string AnswerText { get; set; } = string.Empty;
}
