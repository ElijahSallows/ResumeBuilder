namespace ResumeBuilder.Shared.Interfaces
{
    public interface ISocialLink
    {
        byte[] Image { get; set; }
        string Name { get; set; }
        string Url { get; set; }
    }
}