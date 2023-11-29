namespace PerformanceReviewCleanArchitecture.Application.Features.RatingRecords.Query
{
	public class RatingRecordQueryHandler : IRequestHandler<RatingRecordQuery, IEnumerable<RatingRecord>>
	{
		private readonly IUnitOfWork _unitOfWork;

		public RatingRecordQueryHandler(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public async Task<IEnumerable<RatingRecord>> Handle(RatingRecordQuery request, CancellationToken cancellationToken)
		{
			return await _unitOfWork.RatingRecords.GetAllAsync();
		}
	}
}
