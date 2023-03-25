﻿using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;
using ResumeBuilder.UI.Repositories.Interfaces;
using ResumeBuilder.UI.Services.Interfaces;

namespace ResumeBuilder.UI.Services
{
    public class ResumeModelService : IResumeModelService
    {
        private IResumeInfoRepository _infoRepository;
        private IStateInfoRepository _stateRepository;

        public IResumeInfoModel GetModel()
        {
            int id = _stateRepository.LastUsedModelId;
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

        public ResumeModelService(IResumeInfoRepository infoRepository, IStateInfoRepository stateRepository)
        {
            _infoRepository = infoRepository;
            _stateRepository = stateRepository;
        }
    }
}
