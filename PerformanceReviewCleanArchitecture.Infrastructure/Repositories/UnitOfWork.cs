using PerformanceReviewCleanArchitecture.Application.Interfaces.Repositories;
using PerformanceReviewCleanArchitecture.Application.Interfaces.Repositories.EntityRepositories;
using PerformanceReviewCleanArchitecture.Infrastructure.Data;

namespace PerformanceReviewCleanArchitecture.Infrastructure.Repositories;

internal class UnitOfWork : IUnitOfWork
{
	private readonly DataContext _context;
	public IUserRepository Users { get; }
	public IRatingRecordRepository RatingRecords { get; }
	public IQuestionRepository Questions { get; }
	public ICheckinRecordRepository CheckinRecords { get; }
	public UnitOfWork(DataContext dataContext,
		IUserRepository Users,
		IRatingRecordRepository RatingRecords,
		IQuestionRepository Questions,
		ICheckinRecordRepository CheckinRecords)
	{
		_context = dataContext;
		this.Users = Users;
		this.RatingRecords = RatingRecords;
		this.Questions = Questions;
		this.CheckinRecords = CheckinRecords;
	}

	public int Complete()
	{
		return _context.SaveChanges();
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	private void Dispose(bool disposing)
	{
		if (disposing)
		{
			_context.Dispose();
		}
	}
}
