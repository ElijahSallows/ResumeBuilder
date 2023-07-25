using Blazored.LocalStorage;
using ResumeBuilder.UI.Repositories.Interfaces;

namespace ResumeBuilder.UI.Repositories
{
    public class StateInfoRepository : IStateInfoRepository
    {
        public int LastUsedModelId
        {
            get
            {
                return _localStorageService.GetItem<int>("lastUsedModelId");
            }
            set
            {
                //_localStorageService.SetItem("lastUsedModelId", value);
            }
        }

        private ISyncLocalStorageService _localStorageService;

        public StateInfoRepository(ISyncLocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }


    }
}
