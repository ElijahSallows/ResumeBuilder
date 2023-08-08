using ResumeBuilder.UI.Repositories.Interfaces;

namespace ResumeBuilder.UI.Services.Interfaces
{
    public interface IActiveStateService
    {
        void Initialize(IStateInfoRepository stateRepository);
        bool IsUserInfoVisible { get; set; }
        bool IsAddressInfoVisible { get; set; }
        bool IsSocialsInfoVisible { get; set; }
        bool IsSkillsInfoVisible { get; set; }
        bool IsExperienceInfoVisible { get; set; }
        bool IsEducationInfoVisible { get; set; }
        bool IsProjectInfoVisible { get; set; }
    }
}
