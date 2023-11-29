namespace PerformanceReviewCleanArchitecture.Domain.Common.Interfaces;

public interface IRemovableEntity
{
	bool Removed { get; }
	DateTime RemoveDate { get; set; }
}
