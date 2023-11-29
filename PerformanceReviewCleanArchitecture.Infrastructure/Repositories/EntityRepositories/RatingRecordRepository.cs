using PerformanceReviewCleanArchitecture.Application.Interfaces.Repositories.EntityRepositories;
using PerformanceReviewCleanArchitecture.Domain.Entities;
using PerformanceReviewCleanArchitecture.Infrastructure.Data;

namespace PerformanceReviewCleanArchitecture.Infrastructure.Repositories.EntityRepositories;

public class RatingRecordRepository : GenericRepository<RatingRecord>, IRatingRecordRepository
{
	public RatingRecordRepository(DataContext context) : base(context)
	{
	}
}
