using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class SocialLink : ISocialLink
    {
        public string? Url { get; set; }
        public byte[]? Image { get; set; }
        public string? Name { get; set; }
    }
}
