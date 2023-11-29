using PerformanceReviewCleanArchitecture.Domain.Common.Interfaces;

namespace PerformanceReviewCleanArchitecture.Domain.Common;

public class BaseAuditableRemovableEntity : BaseAuditableEntity, IRemovableEntity
{
	public bool Removed { get; set; }
	public DateTime RemoveDate { get; set; }
}
