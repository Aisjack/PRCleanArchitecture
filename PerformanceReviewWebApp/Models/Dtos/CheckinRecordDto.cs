using System.ComponentModel.DataAnnotations;

namespace PerformanceReview.Models.Dtos
{
    public class CheckinRecordDto
    {
        [Required]
        public int QuestionId { get; set; }
		[Required]
		public int UserId { get; set; }
		[Required]
		public string AnswerText { get; set; } = string.Empty;
    }
}
