
namespace ResumeBuilder.Shared.Models
{
    public class UserInfoModel
    {
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string About { get; set; } = string.Empty;
        public List<SocialLink> Links { get; set; } = new();
    }
}
