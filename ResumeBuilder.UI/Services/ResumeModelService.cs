using Blazored.LocalStorage;
using ResumeBuilder.Shared;
using ResumeBuilder.Shared.Models;
using ResumeBuilder.UI.Repositories.Interfaces;
using ResumeBuilder.UI.Services.Interfaces;
using System.Collections;

namespace ResumeBuilder.UI.Services
{
    public class ResumeModelService : IResumeModelService
    {
        private IResumeInfoRepository _infoRepository = default!;
        private IStateInfoRepository _stateRepository = default!;
        private IResumeGenerationService _generationService = default!;
        
        public int CurrentModelId { get; private set; }
        public bool IsUnsaved { get; set; }

        public ResumeModelService() {}

        public ResumeModelService(IResumeInfoRepository infoRepository, IStateInfoRepository stateRepository, IResumeGenerationService generationService)
        {
            _infoRepository = infoRepository;
            _stateRepository = stateRepository;
            _generationService = generationService;
        }

        public void Initialize(IResumeInfoRepository infoRepository, IStateInfoRepository stateRepository, IResumeGenerationService generationService)
        {
            _infoRepository = infoRepository;
            _stateRepository = stateRepository;
            _generationService = generationService;
        }

        public byte[] GenerateResumeImage(ResumeInfoModel model)
        {
            var images = _generationService.GetImages(model);
            if (images is List<byte[]>)
            {
                var imagesList = images as List<byte[]>;
                return imagesList?[0] ?? Array.Empty<byte>();
            }
            return Array.Empty<byte>();
        }

        public byte[] GenerateResumePdf(ResumeInfoModel model)
        {
            return _generationService.GetPdf(model);
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

        public string GetModelName(int id)
        {
            return _infoRepository.GetResumeModelName(id) ?? "Resume " + (id + 1);
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
