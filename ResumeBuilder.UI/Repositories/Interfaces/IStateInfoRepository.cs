﻿using Blazored.LocalStorage;

namespace ResumeBuilder.UI.Repositories.Interfaces
{
    public interface IStateInfoRepository
    {
        int LastUsedModelId { get; set; }
        bool IsUserInfoVisible { get; set; }
        bool IsAddressInfoVisible { get; set; }
        bool IsSocialsInfoVisible { get; set; }
        bool IsSkillsInfoVisible { get; set; }
        bool IsExperienceInfoVisible { get; set; }
        bool IsEducationInfoVisible { get; set; }
        bool IsProjectInfoVisible { get; set; }
        //void AddLocalStorageService(ISyncLocalStorageService localStorageService);

    }
}
