
namespace ResumeBuilder.Shared.Models
{
    public class Skill
    {
        public string Name { get; set; }

        public Skill(string name)
        {
            Name = name;
        }

        public Skill()
        {
            Name = string.Empty;
        }
    }
}
