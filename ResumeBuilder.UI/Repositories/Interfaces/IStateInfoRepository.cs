using Blazored.LocalStorage;

namespace ResumeBuilder.UI.Repositories.Interfaces
{
    public interface IStateInfoRepository
    {
        int LastUsedModelId { get; set; }
        void AddLocalStorageService(ISyncLocalStorageService localStorageService);

    }
}
