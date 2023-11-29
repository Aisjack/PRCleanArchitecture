namespace PerformanceReviewCleanArchitecture.Application.Features.CheckinRecords.Command;
public record CheckinRecordCreateCommand(CheckinRecordDTO request) : IRequest<CheckinRecord>;
