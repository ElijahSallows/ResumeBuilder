namespace ResumeBuilder.Shared.Interfaces
{
    public interface IResumeInfoModel
    {
        List<IEducation> Education { get; set; }
        List<IExperience> Experiences { get; set; }
        List<IProject> Projects { get; set; }
        List<ISkill> Skills { get; set; }
        IUserInfoModel User { get; set; }
    }
}