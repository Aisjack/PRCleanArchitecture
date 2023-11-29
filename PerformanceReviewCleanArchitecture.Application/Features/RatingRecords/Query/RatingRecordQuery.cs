namespace PerformanceReviewCleanArchitecture.Application.Features.RatingRecords.Query;

public record RatingRecordQuery() : IRequest<IEnumerable<RatingRecord>>;
