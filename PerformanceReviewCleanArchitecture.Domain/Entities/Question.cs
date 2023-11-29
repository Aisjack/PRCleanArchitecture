using PerformanceReviewCleanArchitecture.Domain.Common;

namespace PerformanceReviewCleanArchitecture.Domain.Entities;

public class Question : BaseAuditableRemovableEntity
{
	public string Text { get; set; } = string.Empty;
}
