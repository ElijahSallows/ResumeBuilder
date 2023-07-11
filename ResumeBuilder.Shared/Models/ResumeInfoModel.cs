
namespace ResumeBuilder.Shared.Models
{
    public class ResumeInfoModel
    {
        public UserInfoModel User { get; set; } = new();
        public List<Experience> Experiences { get; set; } = new();
        public List<Skill> Skills { get; set; } = new();
        public List<Project> Projects { get; set; } = new();
        public List<Education> Education { get; set; } = new();
    }
}
