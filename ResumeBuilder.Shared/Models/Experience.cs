namespace ResumeBuilder.ConsoleTesting.Models
{
    public class Experience
    {
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<string> Points { get; set; }
        public bool Current { get; set; }
    }
}
