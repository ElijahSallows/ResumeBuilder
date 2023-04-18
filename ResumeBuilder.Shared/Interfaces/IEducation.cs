namespace ResumeBuilder.Shared.Interfaces
{
    public interface IEducation
    {
        bool Current { get; set; }
        DateTime EndDate { get; set; }
        List<string> Points { get; set; }
        string SchoolName { get; set; }
        DateTime StartDate { get; set; }
        string Title { get; set; }
    }
}