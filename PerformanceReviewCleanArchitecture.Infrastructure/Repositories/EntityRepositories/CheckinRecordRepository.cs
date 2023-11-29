using PerformanceReviewCleanArchitecture.Application.Interfaces.Repositories.EntityRepositories;
using PerformanceReviewCleanArchitecture.Domain.Entities;
using PerformanceReviewCleanArchitecture.Infrastructure.Data;

namespace PerformanceReviewCleanArchitecture.Infrastructure.Repositories.EntityRepositories;

public class CheckinRecordRepository : GenericRepository<CheckinRecord>, ICheckinRecordRepository
{
	public CheckinRecordRepository(DataContext context) : base(context)
	{
	}
}
