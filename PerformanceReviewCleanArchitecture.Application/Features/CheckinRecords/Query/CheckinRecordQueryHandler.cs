using MediatR;
using PerformanceReviewCleanArchitecture.Application.Interfaces.Repositories;
using PerformanceReviewCleanArchitecture.Domain.Entities;

namespace PerformanceReviewCleanArchitecture.Application.Features.CheckinRecords.Query;

public class CheckinRecordQueryHandler : IRequestHandler<CheckinRecordQuery, IEnumerable<CheckinRecord>>
{
	private readonly IUnitOfWork _unitOfWork;
	public CheckinRecordQueryHandler(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	public async Task<IEnumerable<CheckinRecord>> Handle(CheckinRecordQuery request, CancellationToken cancellationToken)
	{
		return await _unitOfWork.CheckinRecords.GetAllAsync();
	}
}
