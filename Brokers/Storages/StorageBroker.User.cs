using AIIELTS.Models;
using Microsoft.EntityFrameworkCore;

namespace AIIELTS.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<User> Users { get; set; }

    }
}
