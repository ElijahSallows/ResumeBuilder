using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class Project : IProject
    {
        public required string Name { get; set; }
        public required string Date { get; set; }
        public required List<string> Points { get; set; }
    }
}
