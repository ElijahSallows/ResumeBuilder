
using QuestPDF.Fluent;
using QuestPDF.Previewer;
using ResumeBuilder.ConsoleTesting.Models;

namespace ResumeBuilder.ConsoleTesting
{
    internal class DocumentBuilder
    {
        private ResumeDocument _doc;

        public DocumentBuilder(ResumeInfo info)
        {
            _doc = new ResumeDocument(info);
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
