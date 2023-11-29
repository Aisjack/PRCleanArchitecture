using PerformanceReviewCleanArchitecture.Application.Interfaces.Repositories.EntityRepositories;
using PerformanceReviewCleanArchitecture.Domain.Entities;
using PerformanceReviewCleanArchitecture.Infrastructure.Data;

namespace PerformanceReviewCleanArchitecture.Infrastructure.Repositories.EntityRepositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
	public UserRepository(DataContext context) : base(context)
	{
	}

	public async Task<User?> GetUserById(int id)
	{
		var userById = await _context.Users.FindAsync(id);
		return userById;
	}
}
