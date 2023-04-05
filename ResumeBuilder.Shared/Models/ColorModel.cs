using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class ColorModel : IColorModel
    {
        public required string Main { get; set; }
        public required string Secondary { get; set; }
        public required string Tertiary { get; set; }
        public required string Quaternary { get; set; }
        public required string Background { get; set; }
        public required string Subfocus { get; set; }
        public required string LightContrast { get; set; }
        public required string MediumContrast { get; set; }
        public required string DarkContrast { get; set; }
        public required string BottomContrast { get; set; }
    }
}
