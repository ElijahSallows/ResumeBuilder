using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.UI.Services.Interfaces
{
    public interface IResumeModelService
    {
        IResumeInfoModel GetModel();
        IResumeInfoModel GetModel(int id);
        Task<bool> VerifyAsync();
    }
}
