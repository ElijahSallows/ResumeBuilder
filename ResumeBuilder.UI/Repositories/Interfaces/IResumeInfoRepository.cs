using ResumeBuilder.Shared.Interfaces;

namespace ResumeBuilder.UI.Repositories.Interfaces
{
    public interface IResumeInfoRepository
    {
        IList<IResumeInfoModel> GetResumeInfoModels();
        IResumeInfoModel GetResumeInfoModel(int id);
    }
}
