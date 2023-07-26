using ResumeBuilder.Shared.Models;
using ResumeBuilder.UI.Repositories.Interfaces;

namespace ResumeBuilder.UI.Services.Interfaces
{
    public interface IResumeModelService
    {
        void Initialize(IResumeInfoRepository infoRepository, IStateInfoRepository stateRepository, IResumeGenerationService generationService);
        int CurrentModelId { get; }
        bool IsUnsaved { get; set; }
        ResumeInfoModel? GetTempModel();
        ResumeInfoModel GetModel();
        ResumeInfoModel GetModel(int id);
        string GetModelName(int id);
        byte[] GenerateResumeImage(ResumeInfoModel model);
        byte[] GenerateResumePdf(ResumeInfoModel model);
        void SaveTemp(ResumeInfoModel model);
        void Save(ResumeInfoModel model);
        void DeleteTemp();
        void Delete();
        ResumeInfoModel DebugRegen();
        //string GetLayoutName(int id);
    }
}
