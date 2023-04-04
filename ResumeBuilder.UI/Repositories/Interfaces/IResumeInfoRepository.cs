using Blazored.LocalStorage;
using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.UI.Repositories.Interfaces
{
    public interface IResumeInfoRepository
    {
        //void AddLocalStorageService(ISyncLocalStorageService localStorageService);
        IList<IResumeInfoModel> GetResumeInfoModels();
        IResumeInfoModel GetResumeInfoModel(int id);
        bool SaveResumeInfoModel(IResumeInfoModel model, string key);
        bool SaveResumeInfoModel(IResumeInfoModel model, int id);
    }
}
