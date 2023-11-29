using PerformanceReviewCleanArchitecture.Domain.Common;

namespace PerformanceReviewCleanArchitecture.Domain.Entities;

public class RatingRecord : BaseAuditableEntity
{
	public int QuestionId { get; set; }
	public int UserId { get; set; }
	public int Rating { get; set; }
}
