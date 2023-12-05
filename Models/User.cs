using AIIELTS.Enums;

namespace AIIELTS.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Profession { get; set; }

    }
}
