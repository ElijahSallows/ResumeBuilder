using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class SectionInfo<T> : ISectionInfo<T>
    {
        public string Name { get; set; }
        public List<T> Bullets { get; set; }
    }
}
