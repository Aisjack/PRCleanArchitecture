namespace PerformanceReviewCleanArchitecture.Api.Controllers
{
	[Route("user")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;
		public UsersController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<User>>> GetUsers()
		{
			var users = await _unitOfWork.Users.GetAllAsync();
			return Ok(users);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<User>> GetUserById(int id)
		{
			var userById = await _unitOfWork.Users.GetUserById(id);
			return Ok(userById);
		}
	}
}
