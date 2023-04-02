using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class UserInfoModel : IUserInfoModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public IAddress Address { get; set; }
        public List<ISocialLink> Links { get; set; }
        public string About { get; set; }
    }
}
