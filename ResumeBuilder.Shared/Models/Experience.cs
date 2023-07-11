
namespace ResumeBuilder.Shared.Models
{
    public class Experience
    {
        public string CompanyName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public List<string> Points { get; set; } = new();
        public bool Current { get; set; }
    }
}
