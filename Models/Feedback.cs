using System.Text.Json.Serialization;

namespace AIIELTS.Models
{
    public class Feedback
    {
        public int? Id { get; set; }
        public int? Grade { get; set; }
        public string? Comment { get; set; }


        public Guid EssayId { get; set; }
        [JsonIgnore]
        public Essay Essay { get; set; }

    }
}
