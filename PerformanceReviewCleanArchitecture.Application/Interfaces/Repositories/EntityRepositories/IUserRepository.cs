namespace PerformanceReviewCleanArchitecture.Application.Interfaces.Repositories.EntityRepositories;
public interface IUserRepository : IGenericRepository<User>
{
	Task<User?> GetUserById(int id);
}
