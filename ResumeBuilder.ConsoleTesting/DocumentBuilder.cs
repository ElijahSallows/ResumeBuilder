using QuestPDF.Fluent;
using QuestPDF.Previewer;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.ConsoleTesting
{
    internal class DocumentBuilder
    {
        private ResumeDocument _doc;
        private DocumentTheme _theme;

        public DocumentBuilder(ResumeInfoModel info, DocumentTheme theme)
        {
            _doc = new ResumeDocument(info, theme);
            _theme = theme;
        }

        public void Build()
        {

            var document = Document.Create(container =>
            {
                _doc.Compose(container);
            });
            //document.GeneratePdf("deleteme.pdf");
            document.ShowInPreviewer();
        }
    }
}
