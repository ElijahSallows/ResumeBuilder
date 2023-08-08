using ResumeBuilder.UI.Repositories.Interfaces;
using ResumeBuilder.UI.Services.Interfaces;

namespace ResumeBuilder.UI.Services
{
    public class ActiveStateService : IActiveStateService
    {
                private IStateInfoRepository _stateRepository = default!;


        public ActiveStateService() { }

        public ActiveStateService(IStateInfoRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public void Initialize(IStateInfoRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public bool IsUserInfoVisible
        {
            get
            {
                return _stateRepository.IsUserInfoVisible;
            }
            set
            {
                _stateRepository.IsUserInfoVisible = value;
            }
        }

        public bool IsAddressInfoVisible
        {
            get
            {
                return _stateRepository.IsAddressInfoVisible;
            }
            set
            {
                _stateRepository.IsAddressInfoVisible = value;
            }
        }

        public bool IsSocialsInfoVisible
        {
            get
            {
                return _stateRepository.IsSocialsInfoVisible;
            }
            set
            {
                _stateRepository.IsSocialsInfoVisible = value;
            }
        }

        public bool IsSkillsInfoVisible
        {
            get
            {
                return _stateRepository.IsSkillsInfoVisible;
            }
            set
            {
                _stateRepository.IsSkillsInfoVisible = value;
            }
        }

        public bool IsExperienceInfoVisible
        {
            get
            {
                return _stateRepository.IsExperienceInfoVisible;
            }
            set
            {
                _stateRepository.IsExperienceInfoVisible = value;
            }
        }

        public bool IsEducationInfoVisible
        {
            get
            {
                return _stateRepository.IsEducationInfoVisible;
            }
            set
            {
                _stateRepository.IsEducationInfoVisible = value;
            }
        }

        public bool IsProjectInfoVisible
        {
            get
            {
                return _stateRepository.IsProjectInfoVisible;
            }
            set
            {
                _stateRepository.IsProjectInfoVisible = value;
            }
        }
    }
}
