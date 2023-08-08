using Blazored.LocalStorage;
using ResumeBuilder.UI.Repositories.Interfaces;

namespace ResumeBuilder.UI.Repositories
{
    public class StateInfoRepository : IStateInfoRepository
    {
        public int LastUsedModelId
        {
            get
            {
                return _localStorageService.GetItem<int>("lastUsedModelId");
            }
            set
            {
                _localStorageService.SetItem("lastUsedModelId", value);
            }
        }

        public bool IsUserInfoVisible
        {
            get
            {
                string key = "isUserInfoVisible";
                return _localStorageService.ContainKey(key) ? _localStorageService.GetItem<bool>(key) : true;
            }
            set
            {
                _localStorageService.SetItem("isUserInfoVisible", value);
            }
        }

        public bool IsAddressInfoVisible
        {
            get
            {
                string key = "isAddressInfoVisible";
                return _localStorageService.ContainKey(key) ? _localStorageService.GetItem<bool>(key) : true;
            }
            set
            {
                _localStorageService.SetItem("isAddressInfoVisible", value);
            }
        }

        public bool IsSocialsInfoVisible
        {
            get
            {
                string key = "isSocialsInfoVisible";
                return _localStorageService.ContainKey(key) ? _localStorageService.GetItem<bool>(key) : true;
            }
            set
            {
                _localStorageService.SetItem("isSocialsInfoVisible", value);
            }
        }

        public bool IsSkillsInfoVisible
        {
            get
            {
                string key = "isSkillsInfoVisible";
                return _localStorageService.ContainKey(key) ? _localStorageService.GetItem<bool>(key) : true;
            }
            set
            {
                _localStorageService.SetItem("isSkillsInfoVisible", value);
            }
        }

        public bool IsExperienceInfoVisible
        {
            get
            {
                string key = "isExperienceInfoVisible";
                return _localStorageService.ContainKey(key) ? _localStorageService.GetItem<bool>(key) : true;
            }
            set
            {
                _localStorageService.SetItem("isExperienceInfoVisible", value);
            }
        }

        public bool IsEducationInfoVisible
        {
            get
            {
                string key = "isEducationInfoVisible";
                return _localStorageService.ContainKey(key) ? _localStorageService.GetItem<bool>(key) : true;
            }
            set
            {
                _localStorageService.SetItem("isEducationInfoVisible", value);
            }
        }

        public bool IsProjectInfoVisible
        {
            get
            {
                string key = "isProjectInfoVisible";
                return _localStorageService.ContainKey(key) ? _localStorageService.GetItem<bool>(key) : true;
            }
            set
            {
                _localStorageService.SetItem("isProjectInfoVisible", value);
            }
        }


        private ISyncLocalStorageService _localStorageService;

        public StateInfoRepository(ISyncLocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }


    }
}
