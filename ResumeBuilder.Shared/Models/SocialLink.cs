
namespace ResumeBuilder.Shared.Models
{
    public class SocialLink
    {
        public string Url { get; set; } = string.Empty;
        public byte[] Image { get; set; } = Array.Empty<byte>();
        public string Name { get; set; } = string.Empty;
    }
}
