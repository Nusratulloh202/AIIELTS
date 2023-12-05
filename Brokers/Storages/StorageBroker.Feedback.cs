
using AIIELTS.Models;
using Microsoft.EntityFrameworkCore;

namespace AIIELTS.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Feedback> Feedbacks { get; set; }



        private static void AddFeedbackConfigurations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feedback>()
                .HasOne(feedback => feedback.Essay)
                .WithOne(essay => essay.Feedback)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
