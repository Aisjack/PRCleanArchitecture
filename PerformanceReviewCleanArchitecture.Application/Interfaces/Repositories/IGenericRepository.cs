namespace PerformanceReviewCleanArchitecture.Application.Interfaces.Repositories;
public interface IGenericRepository<T> where T : class
{
	Task<IEnumerable<T>> GetAllAsync();
	Task<T> AddAsync(T entity);
}
