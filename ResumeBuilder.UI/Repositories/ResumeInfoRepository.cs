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

        public T GetResumeInfoModel<T>(int id)
            where T : IResumeInfoModel
        {
            return _localStorageService.GetItem<T>(RESUME_PREFIX + id);
        }

        public IList<T> GetResumeInfoModels<T>()
            where T : IResumeInfoModel
        {
            throw new NotImplementedException();
            //var a = _localStorageService.Keys().Where(x => x.StartsWith(RESUME_PREFIX));//ToList<IResumeInfoModel>();
        }

        public bool SaveResumeInfoModel(IResumeInfoModel model, string key)
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

        public bool SaveResumeInfoModel(IResumeInfoModel model, int id)
        {
            return SaveResumeInfoModel(model, id.ToString());
        }
    }
}
