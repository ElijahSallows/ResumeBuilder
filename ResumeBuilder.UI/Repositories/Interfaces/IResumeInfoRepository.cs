using Blazored.LocalStorage;
using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.UI.Repositories.Interfaces
{
    public interface IResumeInfoRepository
    {
        //void AddLocalStorageService(ISyncLocalStorageService localStorageService);
        IList<T> GetResumeInfoModels<T>() where T : IResumeInfoModel;
        T GetResumeInfoModel<T>(int id) where T : IResumeInfoModel;
        bool SaveResumeInfoModel(IResumeInfoModel model, string key);
        bool SaveResumeInfoModel(IResumeInfoModel model, int id);
    }
}
