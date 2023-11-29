using System.ComponentModel.DataAnnotations;

namespace PerformanceReview.Models.Dtos
{
    public class RatingRecordDto
    {
		[Required]
		public int QuestionId { get; set; }
		[Required]
		public int UserId { get; set; }
		[Required]
		public int Rating { get; set; }
    }
}
