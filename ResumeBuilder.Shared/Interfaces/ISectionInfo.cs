namespace ResumeBuilder.Shared.Interfaces
{
    public interface ISectionInfo<T>
    {
        List<T> Bullets { get; set; }
        string? Name { get; set; }
    }
}