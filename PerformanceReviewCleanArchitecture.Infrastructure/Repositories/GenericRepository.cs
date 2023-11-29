using Microsoft.EntityFrameworkCore;
using PerformanceReviewCleanArchitecture.Application.Interfaces.Repositories;
using PerformanceReviewCleanArchitecture.Infrastructure.Data;

namespace PerformanceReviewCleanArchitecture.Infrastructure.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
	public readonly DataContext _context;
	public GenericRepository(DataContext context)
	{
		_context = context;
	}

	public async Task<T> AddAsync(T entity)
	{
		await _context.Set<T>().AddAsync(entity);
		return entity;
	}

	public async Task<IEnumerable<T>> GetAllAsync()
	{
		return await _context.Set<T>().ToListAsync();
	}
}
