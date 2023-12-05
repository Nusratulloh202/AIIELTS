using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AIIELTS.Models
{
    public class Essay
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public User  IdUser { get; set; } 
    }
}
