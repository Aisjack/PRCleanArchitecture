using MediatR;
using PerformanceReviewCleanArchitecture.Domain.Entities;

namespace PerformanceReviewCleanArchitecture.Application.Features.CheckinRecords.Query;

public record CheckinRecordQuery() : IRequest<IEnumerable<CheckinRecord>>;

