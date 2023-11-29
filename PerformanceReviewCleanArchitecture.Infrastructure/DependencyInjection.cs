using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PerformanceReviewCleanArchitecture.Application.Interfaces.Repositories;
using PerformanceReviewCleanArchitecture.Application.Interfaces.Repositories.EntityRepositories;
using PerformanceReviewCleanArchitecture.Infrastructure.Data;
using PerformanceReviewCleanArchitecture.Infrastructure.Repositories;
using PerformanceReviewCleanArchitecture.Infrastructure.Repositories.EntityRepositories;

namespace PerformanceReviewCleanArchitecture.Infrastructure;

public static class DependencyInjection
{
	public static IServiceCollection AddInfrastructure(this IServiceCollection services, 
		IConfiguration configuration)
	{
		services.AddDbContext<DataContext>(options =>
		{
			options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
				b => b.MigrationsAssembly(typeof(DataContext).Assembly.FullName));
		});

		services.AddRepositories();
		services.AddUnitOfWork();

		return services;
	}

	public static IServiceCollection AddRepositories(this IServiceCollection services)
	{
		services.AddScoped<IUserRepository, UserRepository>();
		services.AddScoped<IRatingRecordRepository, RatingRecordRepository>();
		services.AddScoped<IQuestionRepository, QuestionRepository>();
		services.AddScoped<ICheckinRecordRepository, CheckinRecordRepository>();

		return services;
	}

	public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
	{
		services.AddScoped<IUnitOfWork, UnitOfWork>();

		return services;
	}
}
