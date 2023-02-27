using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class Skill : ISkill
    {
        public string? Name { get; set; }

        public Skill(string name)
        {
            Name = name;
        }
    }
}
