namespace PerformanceReviewCleanArchitecture.Api.Controllers
{
	[Route("question")]
	[ApiController]
	public class QuestionsController : ControllerBase
	{
		private readonly IMediator _mediator;
		public QuestionsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Question>>> GetAllQuestions()
		{
			return Ok(await _mediator.Send(new GetAllQuestionQuery()));
		}
	}
}
