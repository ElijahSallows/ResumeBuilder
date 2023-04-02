using Blazored.LocalStorage;
using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;
using ResumeBuilder.UI.Repositories.Interfaces;

namespace ResumeBuilder.UI.Services.Interfaces
{
    public interface IResumeModelService
    {
        //void AddLocalStorageService(ISyncLocalStorageService localStorageService);
        void Initialize(ISyncLocalStorageService localStorageService, IResumeInfoRepository infoRepository, IStateInfoRepository stateRepository);
        IResumeInfoModel GetModel();
        IResumeInfoModel GetModel(int id);
        Task<bool> VerifyAsync();
    }
}
