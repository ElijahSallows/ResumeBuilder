using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using SkiaSharp;

namespace ResumeBuilder.ConsoleTesting.Models
{
    internal class ResumeDocument : IDocument
    {
        public ResumeInfo Info { get; }
        public DocumentTheme Theme { get; }

        public ResumeDocument(ResumeInfo info, DocumentTheme theme)
        {
            Info = info;
            Theme = theme;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.MarginVertical(45);
                page.MarginHorizontal(30);
                page.Background().BorderVertical(5).BorderColor(Theme.Colors.Main)
                .BorderHorizontal(10).BorderColor(Theme.Colors.Main);

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
                    columns.ConstantColumn(50);
                    columns.RelativeColumn();
                });
                //table
                table.Cell().ColumnSpan(3);
                //.Canvas((canvas, size) =>
                //{
                //    using var paint = new SKPaint
                //    {
                //        Color = SKColor.Parse(Theme.Colors.Main)
                //    };

                //    canvas.DrawRoundRect(0, 0, size.Width, size.Height, 20, 20, paint);
                //});
                //.LineHorizontal(Theme.TopLineSize)
                //.LineColor(Theme.Colors.Main);


                table.Cell()
                .Column(1)
                .Text(Info.User.Name)
                .FontSize(Theme.NameSize)
                .FontColor(Theme.Colors.Main);

                table.Cell().Column(3).AlignRight().Text(Info.User.Address.City);
                table.Cell().Column(3)
                .Text(text =>
                {
                    text.AlignRight();
                    text.Span(Info.User.Address.State);
                    text.Span(" ");
                    text.Span(Info.User.Address.Zip);
                });
                //.Column(column =>
                //{
                //    column.Item().Text(Info.User.Name);
                //    column.Item().Text(Info.User.Title);
                //});
                
            });
        }
    }
}
