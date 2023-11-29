using PerformanceReviewCleanArchitecture.Domain.Common;

namespace PerformanceReviewCleanArchitecture.Domain.Entities;

public class User : BaseAuditableRemovableEntity
{
	public string Name { get; set; }
	public string Email { get; set; }
}
