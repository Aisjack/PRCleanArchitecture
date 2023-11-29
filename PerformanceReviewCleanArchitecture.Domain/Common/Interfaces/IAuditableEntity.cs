namespace PerformanceReviewCleanArchitecture.Domain.Common.Interfaces;

public interface IAuditableEntity : IEntity
{
	DateTime? CreationDate { get; set; }
}
