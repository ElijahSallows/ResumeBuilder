﻿using ResumeBuilder.Shared.Models;
using ResumeBuilder.UI.Repositories.Interfaces;

namespace ResumeBuilder.UI.Services.Interfaces
{
    public interface IResumeModelService
    {
        void Initialize(IResumeInfoRepository infoRepository, IStateInfoRepository stateRepository);
        int CurrentModelId { get; }
        ResumeInfoModel GetModel();
        ResumeInfoModel GetModel(int id);
        void GenerateResume(ResumeInfoModel model);
        void SaveTemp(ResumeInfoModel model);
        void Save(ResumeInfoModel model);
        void DeleteTemp();
        void Delete();
        ResumeInfoModel DebugRegen();
    }
}
