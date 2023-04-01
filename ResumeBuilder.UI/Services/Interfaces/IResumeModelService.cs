using Blazored.LocalStorage;
using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.UI.Services.Interfaces
{
    public interface IResumeModelService
    {
        //void AddLocalStorageService(ISyncLocalStorageService localStorageService);
        IResumeInfoModel GetModel();
        IResumeInfoModel GetModel(int id);
        Task<bool> VerifyAsync();
    }
}
