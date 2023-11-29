namespace PerformanceReviewCleanArchitecture.Application.Interfaces.Repositories;
public interface IUnitOfWork : IDisposable
{
	IUserRepository Users { get; }
	IRatingRecordRepository RatingRecords { get; }
	IQuestionRepository Questions { get; }
	ICheckinRecordRepository CheckinRecords { get; }
	int Complete();
}
