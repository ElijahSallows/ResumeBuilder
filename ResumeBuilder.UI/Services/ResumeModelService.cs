using ResumeBuilder.Shared.Models;
using ResumeBuilder.UI.Services.Interfaces;

namespace ResumeBuilder.UI.Services
{
    public class ResumeModelService : IResumeModelService
    {
        public ResumeInfoModel GetModel()
        {
            throw new Exception();
        }

        public ResumeInfoModel GetModel(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> VerifyAsync()
        {
            throw new NotImplementedException();
        }
    }
}
