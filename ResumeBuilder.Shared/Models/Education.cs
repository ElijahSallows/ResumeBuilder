using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class Education : IEducation
    {
        public required string SchoolName { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public required List<string> Points { get; set; }
        public required bool Current { get; set; }
        public required string Title { get; set; }
    }
}
