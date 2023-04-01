using ResumeBuilder.Shared;
using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;
using Blazored.LocalStorage;
using ResumeBuilder.UI.Repositories.Interfaces;

namespace ResumeBuilder.UI.Repositories
{
    public class ResumeInfoRepository : IResumeInfoRepository
    {
        private const string RESUME_PREFIX = "resume_";
        private ISyncLocalStorageService _localStorageService;

        public ResumeInfoRepository(ISyncLocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        public IResumeInfoModel GetResumeInfoModel(int id)
        {
            return _localStorageService.GetItem<IResumeInfoModel>(RESUME_PREFIX + id) ?? MockResumeInfo.GetInfo(); // not for final release
            //return MockResumeInfo.GetInfo();
        }

        public IList<IResumeInfoModel> GetResumeInfoModels()
        {
            throw new NotImplementedException();
        }

        public bool SaveResumeInfoModel(IResumeInfoModel model, int id)
        {
            _localStorageService.SetItem(RESUME_PREFIX + id, model);
            return true;
        }
    }
}
