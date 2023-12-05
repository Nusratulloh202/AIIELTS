namespace AIIELTS.Models
{
    public class Feedback
    {
        public int? Id { get; set; }
        public int? Grade { get; set; }
        public string? Comment { get; set; }
        public Essay IdEssay { get; set; }

    }
}
