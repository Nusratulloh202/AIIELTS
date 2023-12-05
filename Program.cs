
using AIIELTS.Brokers.Storages;

namespace AIIELTS
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
      /*      var user = new Models.User
            {
                Id = System.Guid.NewGuid(),
                Name = "Asilbek",
                SurName = "Odilov",
                Age = 21,
                Gender = Enums.Gender.Male,
                Profession = "Student"
            };

            var storageBroker = new StorageBroker.User();
            storageBroker.Users.Add(user);
            storageBroker.SaveChanges();
            Console.WriteLine($"{storageBroker.Users}");*/




            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<StorageBroker>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}