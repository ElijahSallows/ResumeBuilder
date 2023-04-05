using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class SocialLink : ISocialLink
    {
        public required string Url { get; set; }
        public required byte[] Image { get; set; }
        public required string Name { get; set; }
    }
}
