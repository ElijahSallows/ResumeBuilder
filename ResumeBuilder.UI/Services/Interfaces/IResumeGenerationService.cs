using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.UI.Services.Interfaces
{
    public interface IResumeGenerationService
    {
        void DisplayPreviewer(ResumeInfoModel model);
        byte[] GetPdf(ResumeInfoModel model);
        byte[] GetXps(ResumeInfoModel model);
        IEnumerable<byte[]> GetImages(ResumeInfoModel model);
    }
}
