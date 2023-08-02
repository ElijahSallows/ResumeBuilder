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

        public bool DeleteResumeInfoModel(int id)
        {
            return DeleteResumeInfoModel(id.ToString());
        }

        public bool DeleteResumeInfoModel(string key)
        {
            if (!_localStorageService.ContainKey(RESUME_PREFIX + key))
            {
                return false;
            }
            _localStorageService.RemoveItem(RESUME_PREFIX + key);
         
            return true;
        }

        public List<ResumeInfoModel> GetResumeInfoModels()
        {
            throw new NotImplementedException();
            //var a = _localStorageService.Keys().Where(x => x.StartsWith(RESUME_PREFIX));//ToList<ResumeInfoModel>();
        }

        public ResumeInfoModel GetResumeInfoModel(int id)
        {
            return GetResumeInfoModel(id.ToString());
        }

        public ResumeInfoModel GetResumeInfoModel(string key)
        {
            return _localStorageService.GetItem<ResumeInfoModel>(RESUME_PREFIX + key);
        }

        public string? GetResumeModelName(int id)
        {
            return _localStorageService.GetItem<string>(RESUME_PREFIX + "name" + id.ToString());
        }

        public bool SaveResumeInfoModel(ResumeInfoModel model, int id)
        {
            return SaveResumeInfoModel(model, id.ToString());
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
    }
}
