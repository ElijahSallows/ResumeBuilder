
namespace ResumeBuilder.Shared.Models
{
    public class ResumeInfoModel
    {
        public Section<UserInfoModel> User { get; set; } = new();
        public Section<Address> Address { get; set; } = new();
        public Section<List<Experience>> Experiences { get; set; } = new();
        public Section<List<Skill>> Skills { get; set; } = new();
        public Section<List<Project>> Projects { get; set; } = new();
        public Section<List<Education>> Education { get; set; } = new();
    }
}
