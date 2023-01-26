using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ResumeBuilder.ConsoleTesting.Components;

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
                page.MarginVertical(20);
                page.MarginHorizontal(30);
                page.PageColor(Theme.Colors.Secondary);
                page.Background().BorderVertical(5).BorderColor(Theme.Colors.Main)
                .BorderHorizontal(10).BorderColor(Theme.Colors.Main);

                page.Header().AlignTop().Background(Theme.Colors.Background).Element(ComposeHeader);

                page.Content().Background(Theme.Colors.Background).Element(ComposeContent);

                page.Footer().AlignBottom().Background(Theme.Colors.BottomContrast).Element(ComposeFooter);
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

                // Left side. User's name.
                var socials = new SocialsComponent(Info.User.Links, Theme);

                table.Cell()
                .Column(1)
                .Row(1)
                .RowSpan(2)
                .Background(Colors.DeepOrange.Lighten3)
                .MinHeight(20)
                .PaddingBottom(40)
                .Text(Info.User.Name)
                .FontSize(Theme.NameSize)
                .FontColor(Theme.Colors.Main);

                table.Cell()
                .Column(1)
                .ColumnSpan(3)
                .Row(2)
                .AlignBottom()
                .Background(Colors.DeepOrange.Lighten4)
                .PaddingTop(0)
                .Component(socials);

                var dir = AppDomain.CurrentDomain.BaseDirectory;
            table.Cell()
            .Width(16)
            .Height(16)
            .Image(dir + "/Sources/linkedin.png");



                // Right side. Contains rough idea of where User lives as well as contact info.
                var addressEmail = new ContactComponent(Info.User.Address, Info.User.Email, Info.User.Phone, Theme);


                table.Cell().Column(3).RowSpan(2).Component(addressEmail);
            });
        }

        public void ComposeFooter(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });


                // I'll need to find a way to streamline this.
                // I think I can set it as .Element() or something.
                table.Cell()
                    .Row(1)
                    .Column(2)
                    .ColumnSpan(2)
                    .AlignMiddle()
                    .AlignCenter()//.PaddingRight(30)
                    .Text(Theme.ContactMeTextVisible ? "Please consider interviewing me." : "")
                    .FontColor(Colors.White)
                    .FontSize(Theme.ContactComponentTextSize);

                table.Cell()
                    .Row(2)
                    .Column(2)
                    .ColumnSpan(2)
                    .AlignMiddle()
                    .AlignCenter()//.PaddingRight(10)
                    .Text($"{Info.User.Phone} - {Info.User.Email}")
                    .FontColor(Colors.White)
                    .FontSize(Theme.ContactComponentTextSize);

                /*
                table.Cell().Row(2).Column(2).AlignMiddle().AlignRight().PaddingRight(10)
                    .Text(Info.User.Phone)
                    .FontColor(Colors.White)
                    .FontSize(Theme.ContactComponentTextSize);

                table.Cell().Row(2).Column(3).AlignMiddle().AlignLeft().PaddingRight(10)
                    .Text(Info.User.Email)
                    .FontColor(Colors.White)
                    .FontSize(Theme.ContactComponentTextSize);
                */
            });
        }

        public void ComposeContent(IContainer container)
        {

        }
    }
}
