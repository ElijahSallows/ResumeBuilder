using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.Shared.Models
{
    public class ResumeInfoModel : IResumeInfoModel
    {
        public required IUserInfoModel User { get; set; }
        public required List<IExperience> Experiences { get; set; }
        public required List<ISkill> Skills { get; set; }
        public required List<IProject> Projects { get; set; }
        public required List<IEducation> Education { get; set; }
    }
}
