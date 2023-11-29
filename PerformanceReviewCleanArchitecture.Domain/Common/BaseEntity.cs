using PerformanceReviewCleanArchitecture.Domain.Common.Interfaces;

namespace PerformanceReviewCleanArchitecture.Domain.Common;

public class BaseEntity : IEntity
{
	public int Id { get; set; }
}
