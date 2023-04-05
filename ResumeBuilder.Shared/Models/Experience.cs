using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class Experience : IExperience
    {
        public required string CompanyName { get; set; }
        public required string Title { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public required List<string> Points { get; set; }
        public required bool Current { get; set; }
    }
}
