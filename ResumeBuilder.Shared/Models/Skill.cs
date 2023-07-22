
namespace ResumeBuilder.Shared.Models
{
    public class Skill
    {
        public string Name { get; set; }
        public bool Hard { get; set; }

        public Skill(string name)
        {
            Name = name;
            Hard = true;
        }

        public Skill()
        {
            Name = string.Empty;
            Hard = true;
        }
    }
}
