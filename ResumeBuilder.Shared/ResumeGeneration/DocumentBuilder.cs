using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.Shared.ResumeGeneration
{
    public class DocumentBuilder
    {
        private IDocument _doc;
        private DocumentTheme _theme;

        public DocumentBuilder(ResumeInfoModel info, DocumentTheme theme)
        {
            //_doc = new OldResumeDocument(info, theme);
            _doc = new ResumeDocument(info, theme);
            _theme = theme;
        }

        private Document Build()
        {
            return Document.Create(container =>
            {
                _doc.Compose(container);
            });
            //document.GeneratePdf("deleteme.pdf");
        }

        public IEnumerable<byte[]> BuildImages()
        {
            return Build().GenerateImages();
        }

        public byte[] BuildPdf()
        {
            return Build().GeneratePdf();
        }

        public byte[] BuildXps()
        {
            return Build().GenerateXps();
        }

        public void BuildPreview()
        {
            Build().ShowInPreviewer();
        }
    }
}
