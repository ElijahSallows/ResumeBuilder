using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class ResumeInfoModel : IResumeInfoModel
    {
        public IUserInfoModel User { get; set; }
        public List<IExperience> Experiences { get; set; }
        public ISectionInfo<ISkill> Skills { get; set; }
        public List<IProject> Projects { get; set; }
        public List<IEducation> Education { get; set; }
    }
}
