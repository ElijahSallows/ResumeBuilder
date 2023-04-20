using Blazored.LocalStorage;
using ResumeBuilder.Shared;
using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;
using ResumeBuilder.UI.Repositories.Interfaces;
using ResumeBuilder.UI.Services.Interfaces;

namespace ResumeBuilder.UI.Services
{
    public class ResumeModelService<T> : IResumeModelService
        where T : class, IResumeInfoModel, new()
    {
        private IResumeInfoRepository _infoRepository = default!;
        private IStateInfoRepository _stateRepository = default!;
        
        public int CurrentModelId { get; private set; }

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

        public IResumeInfoModel DebugRegen()
        {
            return MockResumeInfo.GetInfo();
        }

        public void GenerateResume(IResumeInfoModel model)
        {
            throw new NotImplementedException();
        }

        public IResumeInfoModel GetModel()
        {
            int id = _stateRepository?.LastUsedModelId ?? 0;
            return GetModel(id);
        }

        public IResumeInfoModel GetModel(int id)
        {
            CurrentModelId = id;
            return _infoRepository?.GetResumeInfoModel<T>(id) ?? new T();
        }

        public void SaveTemp(IResumeInfoModel model)
        {
            if (model == null)
            {
                return;
            }

            _infoRepository.SaveResumeInfoModel(model, "temp");
        }

        public void Save(IResumeInfoModel model)
        {
            if (model == null)
            {
                return;
            }

            _infoRepository.SaveResumeInfoModel(model, CurrentModelId);
        }

        public void DeleteTemp()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
