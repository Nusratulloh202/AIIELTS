using AIIELTS.Models;
using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace AIIELTS.Brokers.Storages
{
    public partial class StorageBroker:EFxceptionsContext
    {
        private readonly  IConfiguration configuration;

        public StorageBroker(IConfiguration configuration   )
        {
            this.configuration = configuration;
            this.Database.Migrate();
        }

        //public DbSet<User> Users { get; set; }
        //public DbSet<Essay> Essays { get; set; }
        //public DbSet<Feedback> Feedbacks { get; set; }

        public StorageBroker() =>
            this.Database.EnsureCreated();



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string connectionString =
                this.configuration.GetConnectionString(name: "DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            AddEssayConfigurations(modelBuilder);
            AddFeedbackConfigurations(modelBuilder);
        }

        public override void Dispose() { }
        



}
}


