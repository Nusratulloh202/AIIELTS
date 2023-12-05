using AIIELTS.Models;
using Microsoft.EntityFrameworkCore;

namespace AIIELTS.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Essay> Essays { get; set; }
        private static void AddEssayConfigurations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Essay>()
                .HasOne(essay => essay.User)
                .WithMany(user => user.Essays)
                .HasForeignKey(essay => essay.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
