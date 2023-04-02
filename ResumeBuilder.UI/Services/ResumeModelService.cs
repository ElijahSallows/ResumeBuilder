using Blazored.LocalStorage;
using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;
using ResumeBuilder.UI.Repositories.Interfaces;
using ResumeBuilder.UI.Services.Interfaces;

namespace ResumeBuilder.UI.Services
{
    public class ResumeModelService : IResumeModelService
    {
        private IResumeInfoRepository _infoRepository = default!;
        private IStateInfoRepository _stateRepository = default!;
        private ISyncLocalStorageService _localStorageService = default!;

        public ResumeModelService() {}

        public ResumeModelService(ISyncLocalStorageService localStorageService, IResumeInfoRepository infoRepository, IStateInfoRepository stateRepository)
        {
            _localStorageService = localStorageService;
            _infoRepository = infoRepository;
            _stateRepository = stateRepository;
        }

        public void Initialize(ISyncLocalStorageService localStorageService, IResumeInfoRepository infoRepository, IStateInfoRepository stateRepository)
        {
            _localStorageService = localStorageService;
            _infoRepository = infoRepository;
            _stateRepository = stateRepository;
        }

        public IResumeInfoModel GetModel()
        {
            int id = _stateRepository?.LastUsedModelId ?? 0;
            return GetModel(id);
        }

        public IResumeInfoModel GetModel(int id)
        {
            return _infoRepository.GetResumeInfoModel(id);
        }

        public Task<bool> VerifyAsync()
        {
            throw new NotImplementedException();
        }

    }
}
