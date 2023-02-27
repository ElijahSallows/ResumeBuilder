namespace ResumeBuilder.Shared.Interfaces
{
    public interface IColorModel
    {
        string? Background { get; set; }
        string? BottomContrast { get; set; }
        string? DarkContrast { get; set; }
        string? LightContrast { get; set; }
        string? Main { get; set; }
        string? MediumContrast { get; set; }
        string? Quaternary { get; set; }
        string? Secondary { get; set; }
        string? Subfocus { get; set; }
        string? Tertiary { get; set; }
    }
}