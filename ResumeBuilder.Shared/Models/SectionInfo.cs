using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class SectionInfo<T> : ISectionInfo<T>
    {
        public required string Name { get; set; }
        public required List<T> Bullets { get; set; }
    }
}
