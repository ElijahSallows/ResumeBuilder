
namespace ResumeBuilder.Shared.Models
{
    public class ResumeInfoModel
    {
        public UserInfoModel User { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Project> Projects { get; set; }
        public List<Education> Education { get; set; }
    }
}
