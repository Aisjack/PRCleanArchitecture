namespace PerformanceReviewCleanArchitecture.Application.Features.Questions.Query;

public record GetAllQuestionQuery() : IRequest<IEnumerable<Question>>;

