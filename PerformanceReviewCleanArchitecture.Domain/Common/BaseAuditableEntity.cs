using PerformanceReviewCleanArchitecture.Domain.Common.Interfaces;

namespace PerformanceReviewCleanArchitecture.Domain.Common;

public class BaseAuditableEntity : BaseEntity, IAuditableEntity
{
	public DateTime? CreationDate { get; set; }
}
