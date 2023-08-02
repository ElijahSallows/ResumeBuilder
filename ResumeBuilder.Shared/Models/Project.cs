
namespace ResumeBuilder.Shared.Models
{
    public class Project
    {
        public string Name { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public List<string> Points { get; set; } = new();
    }
}
