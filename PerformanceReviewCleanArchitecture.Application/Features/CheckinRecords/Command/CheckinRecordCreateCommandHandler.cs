namespace PerformanceReviewCleanArchitecture.Application.Features.CheckinRecords.Command;

public record CheckinRecordCreateCommandHandler : IRequestHandler<CheckinRecordCreateCommand, CheckinRecord>
{
	private readonly IUnitOfWork _unitOfWork;
	public CheckinRecordCreateCommandHandler(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	public async Task<CheckinRecord> Handle(CheckinRecordCreateCommand request, CancellationToken cancellationToken)
	{
		var checkinRecordData = new CheckinRecord
		{
			QuestionId = request.request.QuestionId,
			UserId = request.request.UserId,
			AnswerText = request.request.AnswerText,
			CreationDate = DateTime.Now
		};

		await _unitOfWork.CheckinRecords.AddAsync(checkinRecordData);
		_unitOfWork.Complete();

		return checkinRecordData;
	}
}
