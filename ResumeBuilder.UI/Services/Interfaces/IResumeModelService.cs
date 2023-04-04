using Blazored.LocalStorage;
using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;
using ResumeBuilder.UI.Repositories.Interfaces;

namespace ResumeBuilder.UI.Services.Interfaces
{
    public interface IResumeModelService
    {
        void Initialize(IResumeInfoRepository infoRepository, IStateInfoRepository stateRepository);
        IResumeInfoModel GetModel();
        IResumeInfoModel GetModel(int id);
        void SaveTemp(IResumeInfoModel model);
        void Save(IResumeInfoModel model, int id);
        void DeleteTemp();
        void Delete(int id);
    }
}
