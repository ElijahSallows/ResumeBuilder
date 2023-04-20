using Blazored.LocalStorage;
using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;
using ResumeBuilder.UI.Repositories.Interfaces;

namespace ResumeBuilder.UI.Services.Interfaces
{
    public interface IResumeModelService
    {
        void Initialize(IResumeInfoRepository infoRepository, IStateInfoRepository stateRepository);
        int CurrentModelId { get; }
        IResumeInfoModel GetModel();
        IResumeInfoModel GetModel(int id);
        void GenerateResume(IResumeInfoModel model);
        void SaveTemp(IResumeInfoModel model);
        void Save(IResumeInfoModel model);
        void DeleteTemp();
        void Delete();
        IResumeInfoModel DebugRegen();
    }
}
