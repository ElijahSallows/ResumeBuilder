using Blazored.LocalStorage;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.UI.Repositories.Interfaces
{
    public interface IResumeInfoRepository
    {
        //void AddLocalStorageService(ISyncLocalStorageService localStorageService);
        List<ResumeInfoModel> GetResumeInfoModels();
        ResumeInfoModel GetResumeInfoModel(string key);
        ResumeInfoModel GetResumeInfoModel(int id);
        string? GetResumeModelName(int id);
        bool SaveResumeInfoModel(ResumeInfoModel model, string key);
        bool SaveResumeInfoModel(ResumeInfoModel model, int id);
        bool DeleteResumeInfoModel(string key);
        bool DeleteResumeInfoModel(int id);
    }
}
