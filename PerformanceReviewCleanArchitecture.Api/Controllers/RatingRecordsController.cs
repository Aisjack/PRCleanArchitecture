using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PerformanceReviewCleanArchitecture.Application.Features.RatingRecords.Command;
using PerformanceReviewCleanArchitecture.Application.Features.RatingRecords.Query;

namespace PerformanceReviewCleanArchitecture.Api.Controllers
{
	[Route("rating")]
	[ApiController]
	public class RatingRecordsController : ControllerBase
	{
		private readonly IMediator _mediator;
		public RatingRecordsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<RatingRecord>>> GetAllRatingRecords()
		{
			var ratingRecords = await _mediator.Send(new RatingRecordQuery());
			return Ok(ratingRecords);
		}

		[HttpPost]
		public async Task<ActionResult<RatingRecord>> RatingRecordCreate(RatingRecordDTO request)
		{
			await _mediator.Send(new RatingRecordCreateCommand(request));
			return Ok(request);
		}

	}
}
