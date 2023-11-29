using PerformanceReviewCleanArchitecture.Application.Interfaces.Repositories.EntityRepositories;
using PerformanceReviewCleanArchitecture.Domain.Entities;
using PerformanceReviewCleanArchitecture.Infrastructure.Data;

namespace PerformanceReviewCleanArchitecture.Infrastructure.Repositories.EntityRepositories;

public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
{
	public QuestionRepository(DataContext context) : base(context)
	{
	}
}
