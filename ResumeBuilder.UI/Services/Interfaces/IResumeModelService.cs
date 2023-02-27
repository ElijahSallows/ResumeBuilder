using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.UI.Services.Interfaces
{
    public interface IResumeModelService
    {
        ResumeInfoModel GetModel();
        ResumeInfoModel GetModel(int id);
        Task<bool> VerifyAsync();
    }
}
