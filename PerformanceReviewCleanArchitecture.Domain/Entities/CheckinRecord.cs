using PerformanceReviewCleanArchitecture.Domain.Common;

namespace PerformanceReviewCleanArchitecture.Domain.Entities;

public class CheckinRecord : BaseAuditableEntity
{
	public int QuestionId { get; set; }
	public int UserId { get; set; }
	public string AnswerText { get; set; } = string.Empty;
}
