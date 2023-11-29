namespace PerformanceReviewCleanArchitecture.Application.Features.RatingRecords.Command;

public record RatingRecordCreateCommand(RatingRecordDTO request) : IRequest<RatingRecord>;
