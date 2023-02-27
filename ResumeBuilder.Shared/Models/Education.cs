using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class Education : IEducation
    {
        public string? SchoolName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<string>? Points { get; set; }
        public bool Current { get; set; }
    }
}
