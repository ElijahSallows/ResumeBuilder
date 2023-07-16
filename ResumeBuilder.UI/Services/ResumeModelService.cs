using ResumeBuilder.Shared;
using ResumeBuilder.Shared.Models;
using ResumeBuilder.UI.Repositories.Interfaces;
using ResumeBuilder.UI.Services.Interfaces;

namespace ResumeBuilder.UI.Services
{
    public class ResumeModelService : IResumeModelService
    {
        private IResumeInfoRepository _infoRepository = default!;
        private IStateInfoRepository _stateRepository = default!;
        
        public int CurrentModelId { get; private set; }
        public bool IsUnsaved { get; private set; }

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

        public ResumeInfoModel DebugRegen()
        {
            return MockResumeInfo.GetInfo();
        }

        public void GenerateResume(ResumeInfoModel model)
        {
            throw new NotImplementedException();
        }

        public ResumeInfoModel GetTempModel()
        {
            return _infoRepository.GetResumeInfoModel("temp");
        }

        public ResumeInfoModel GetModel()
        {
            int id = _stateRepository?.LastUsedModelId ?? 0;
            return GetModel(id);
        }

        public ResumeInfoModel GetModel(int id)
        {
            CurrentModelId = id;
            IsUnsaved = false;
            return _infoRepository?.GetResumeInfoModel(id) ?? new ResumeInfoModel();
        }

        public void SaveTemp(ResumeInfoModel model)
        {
            if (model == null)
            {
                return;
            }

            IsUnsaved = true;
            _infoRepository.SaveResumeInfoModel(model, "temp");
        }

        public void Save(ResumeInfoModel model)
        {
            if (model == null)
            {
                return;
            }

            _infoRepository.SaveResumeInfoModel(model, CurrentModelId);
            IsUnsaved = false;
            DeleteTemp();
        }

        public void DeleteTemp()
        {
            _infoRepository.DeleteResumeInfoModel("temp");
        }

        public void Delete()
        {
            _infoRepository.DeleteResumeInfoModel(CurrentModelId);
        }
    }
}
