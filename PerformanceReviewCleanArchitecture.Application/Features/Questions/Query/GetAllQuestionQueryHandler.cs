namespace PerformanceReviewCleanArchitecture.Application.Features.Questions.Query;
public class GetAllQuestionQueryHandler : IRequestHandler<GetAllQuestionQuery, IEnumerable<Question>>
{
	private readonly IUnitOfWork _unitOfWork;
	public GetAllQuestionQueryHandler(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	public async Task<IEnumerable<Question>> Handle(GetAllQuestionQuery request, CancellationToken cancellationToken)
	{
		return await _unitOfWork.Questions.GetAllAsync();
	}
}
