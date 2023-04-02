namespace ResumeBuilder.Shared.Interfaces
{
    public interface IProject
    {
        string Date { get; set; }
        string Name { get; set; }
        List<string> Points { get; set; }
    }
}