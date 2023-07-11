
namespace ResumeBuilder.Shared.Models
{
    public class UserInfoModel
    {
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public Address Address { get; set; } = new();
        public List<SocialLink> Links { get; set; } = new();
        public string About { get; set; } = string.Empty;
    }
}
