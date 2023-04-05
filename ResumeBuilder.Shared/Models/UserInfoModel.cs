using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class UserInfoModel : IUserInfoModel
    {
        public required string Name { get; set; }
        public required string Title { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required IAddress Address { get; set; }
        public required List<ISocialLink> Links { get; set; }
        public required string About { get; set; }
    }
}
