namespace PerformanceReviewCleanArchitecture.Application.Features.RatingRecords.Command
{
	public class RatingRecordCreateCommandHandler : IRequestHandler<RatingRecordCreateCommand, RatingRecord>
	{
		private readonly IUnitOfWork _unitOfWork;
		public RatingRecordCreateCommandHandler(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public async Task<RatingRecord> Handle(RatingRecordCreateCommand request, CancellationToken cancellationToken)
		{
			var ratingRecordData = new RatingRecord
			{
				QuestionId = request.request.QuestionId,
				UserId = request.request.UserId,
				Rating = request.request.Rating,
				CreationDate = DateTime.Now
			};

			await _unitOfWork.RatingRecords.AddAsync(ratingRecordData);
			_unitOfWork.Complete();

			return ratingRecordData;
		}
	}
}
