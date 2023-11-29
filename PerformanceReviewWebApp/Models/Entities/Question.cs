namespace PerformanceReview.Models.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public bool Active { get; set; } = true;
    }
}
