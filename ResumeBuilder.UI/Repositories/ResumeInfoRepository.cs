using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.UI.Repositories.Interfaces;

namespace ResumeBuilder.UI.Repositories
{
    public class ResumeInfoRepository : IResumeInfoRepository
    {
        // needs access to database
        // how to do dependency injection?
        //public ResumeInfoRepository()

        public IResumeInfoModel GetResumeInfoModel(int id)
        {
            throw new NotImplementedException();
        }

        public IList<IResumeInfoModel> GetResumeInfoModels()
        {
            throw new NotImplementedException();
        }
    }
}
