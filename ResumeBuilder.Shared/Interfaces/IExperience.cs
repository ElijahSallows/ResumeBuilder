namespace ResumeBuilder.Shared.Interfaces
{
    public interface IExperience
    {
        string? CompanyName { get; set; }
        bool Current { get; set; }
        DateTime? EndDate { get; set; }
        List<string>? Points { get; set; }
        DateTime StartDate { get; set; }
        string? Title { get; set; }
    }
}