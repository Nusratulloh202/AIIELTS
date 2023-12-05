using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AIIELTS.Models
{
    public class Essay
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public Guid  UserId { get; set; }


        [JsonIgnore]
        public User User { get; set; }

        [JsonIgnore]
        public Feedback Feedback { get; set; }
    }
}
