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

        public ResumeModelService() {}

        public ResumeModelService(IResumeInfoRepository infoRepository, IStateInfoRepository stateRepository)
        {
            _infoRepository = infoRepository;
            _stateRepository = stateRepository;
        }

        public void Initialize(IResumeInfoRepository infoRepository, IStateInfoRepository stateRepository)
        {
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

        public void SaveTemp(IResumeInfoModel model)
        {
            if (model == null)
            {
                return;
            }
            _infoRepository.SaveResumeInfoModel(model, "temp");
        }

        public void Save(IResumeInfoModel model, int id)
        {
            if (model == null)
            {
                return;
            }
            _infoRepository.SaveResumeInfoModel(model, id);
        }

        public void DeleteTemp()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
