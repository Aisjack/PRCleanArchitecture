using Microsoft.EntityFrameworkCore;
using PerformanceReviewCleanArchitecture.Domain.Entities;
using System.Reflection;

namespace PerformanceReviewCleanArchitecture.Infrastructure.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<CheckinRecord> CheckinRecords { get; set; }
    public DbSet<RatingRecord> RatingRecords { get; set; }
}
