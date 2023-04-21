using ResumeBuilder.Shared;
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

        public ResumeInfoModel GetResumeInfoModel(int id)
        {
            return _localStorageService.GetItem<ResumeInfoModel>(RESUME_PREFIX + id);
        }

        public IList<ResumeInfoModel> GetResumeInfoModels()
        {
            throw new NotImplementedException();
            //var a = _localStorageService.Keys().Where(x => x.StartsWith(RESUME_PREFIX));//ToList<ResumeInfoModel>();
        }

        public bool SaveResumeInfoModel(ResumeInfoModel model, string key)
        {
            try
            {
                _localStorageService.SetItem(RESUME_PREFIX + key, model);
                return true;
            }
            catch 
            {
                //log exception
                return false;
            }
        }

        public bool SaveResumeInfoModel(ResumeInfoModel model, int id)
        {
            return SaveResumeInfoModel(model, id.ToString());
        }
    }
}
