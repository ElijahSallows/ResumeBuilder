namespace ResumeBuilder.ConsoleTesting.Models
{
    public class ResumeInfo
    {
        public UserInfo? User { get; set; }
        public ExperienceInfo? Experience { get; set; }
        public SectionInfo<Skill>? Skills { get; set; }
        public List<Project>? Projects { get; set; }
        public List<Education>? Education { get; set; }
    }
}
