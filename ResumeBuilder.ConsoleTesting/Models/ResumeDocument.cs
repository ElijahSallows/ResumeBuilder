using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ResumeBuilder.ConsoleTesting.Models
{
    internal class ResumeDocument : IDocument
    {
        public ResumeInfo Info { get; }

        public ResumeDocument(ResumeInfo info)
        {
            Info = info;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(50);

                page.Header().Element(ComposeHeader);

                page.Content().Background(Colors.Grey.Lighten3);

                page.Footer().Height(50).Background(Colors.Grey.Lighten1);
            });


        }

        public void ComposeHeader(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.ConstantColumn(50);
                });

                table.Cell()
                .AlignLeft()
                .Column(column =>
                {
                    column.Item().Text(Info.User.Name);
                    column.Item().Text(Info.User.Title);
                });
                
            });
        }
    }
}
