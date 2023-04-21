using Blazored.LocalStorage;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.UI.Repositories.Interfaces
{
    public interface IResumeInfoRepository
    {
        //void AddLocalStorageService(ISyncLocalStorageService localStorageService);
        IList<ResumeInfoModel> GetResumeInfoModels();
        ResumeInfoModel GetResumeInfoModel(int id);
        bool SaveResumeInfoModel(ResumeInfoModel model, string key);
        bool SaveResumeInfoModel(ResumeInfoModel model, int id);
    }
}
