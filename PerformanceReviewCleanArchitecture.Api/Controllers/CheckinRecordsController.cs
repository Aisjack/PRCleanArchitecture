namespace PerformanceReviewCleanArchitecture.Api.Controllers
{
	[Route("checkin")]
	[ApiController]
	public class CheckinRecordsController : ControllerBase
	{
		private readonly IMediator _mediator;
		public CheckinRecordsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<CheckinRecord>>> GetAllCheckinRecords()
		{
			var records = await _mediator.Send(new CheckinRecordQuery());
			return Ok(records);
		}

		[HttpPost]
		public async Task<ActionResult<CheckinRecord>> CheckinRecordCreate(CheckinRecordDTO request)
		{
			await _mediator.Send(new CheckinRecordCreateCommand(request));
			return Ok(request);
		}
	}
}
