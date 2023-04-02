using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class Project : IProject
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public List<string> Points { get; set; }
    }
}
