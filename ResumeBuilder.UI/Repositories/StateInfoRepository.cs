using Blazored.LocalStorage;
using ResumeBuilder.UI.Repositories.Interfaces;

namespace ResumeBuilder.UI.Repositories
{
    public class StateInfoRepository : IStateInfoRepository
    {
        public int LastUsedModelId { get; set; }

        private ISyncLocalStorageService _localStorageService;

        public void AddLocalStorageService(ISyncLocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }


    }
}
