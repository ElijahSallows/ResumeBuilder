using ResumeBuilder.Shared.Models;
using ResumeBuilder.Shared.ResumeGeneration;
using ResumeBuilder.UI.Services.Interfaces;

namespace ResumeBuilder.UI.Services
{
    public class ResumeGenerationService : IResumeGenerationService
    {
        public DocumentTheme Theme { get; set; }

        public ResumeGenerationService(DocumentTheme? theme = null)
        {
            Theme = theme ?? new DocumentTheme();
        }

        private DocumentBuilder GetBuilder(ResumeInfoModel model)
        {
            return new DocumentBuilder(model, Theme);
        }

        public IEnumerable<byte[]> GetImages(ResumeInfoModel model)
        {
            return GetBuilder(model).BuildImages();
        }

        public byte[] GetPdf(ResumeInfoModel model)
        {
            return GetBuilder(model).BuildPdf();
        }

        public byte[] GetXps(ResumeInfoModel model)
        {
            return GetBuilder(model).BuildXps();
        }

        public void DisplayPreviewer(ResumeInfoModel model)
        {
            GetBuilder(model).BuildPreview();
        }
    }
}
