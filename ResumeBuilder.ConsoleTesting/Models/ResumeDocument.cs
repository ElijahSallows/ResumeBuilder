using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ResumeBuilder.ConsoleTesting.Components;
using System.Runtime.CompilerServices;

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

                // Right side. Contains rough idea of where User lives as well as contact info.
                var addressEmail = new ContactComponent(Info.User.Address, 
                    Info.User.Email, 
                    Info.User.Phone, 
                    Theme);


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
            container.PaddingTop(10f)
                .Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn();
                    columns.RelativeColumn();// columns.RelativeColumn();
                });


                // Section headers
                table.Cell()
                .Row(1)
                .Column(1)
                .Element(SectionHeader)
                .Text("Skills");
                table.Cell()
                .Row(3)
                .Column(1)
                .Element(SectionHeader)
                .Text("Featured Projects");
                table.Cell()
                .Row(1)
                .Column(2)
                .Element(SectionHeader)
                .Text("Experience");
                table.Cell()
                .Row(3)
                .Column(2)
                .Element(SectionHeader)
                .Text("Education");

                // Component declarations
                var skillsComponent = new SkillsComponent(Info.Skills.Bullets, Theme);
                //var projectsComponent = new ProjectsComponent();
                //var experienceComponent = new ExperienceComponent();
                //var educationComponent = new EducationComponent();

                // Main components
                table.Cell()
                .Row(2)
                .Column(1)
                .Component(skillsComponent);
            });
        }

        public IContainer SectionHeader(IContainer container)
        {
            var textStyle = new TextStyle();

            textStyle = textStyle
                .FontColor(Colors.White)
                .FontSize(Theme.ContactComponentTextSize);

            return container.DefaultTextStyle(textStyle)
                .ExtendHorizontal()
                .Background(Theme.Colors.Main)
                .BorderColor(Theme.Colors.Background)
                .Border(3)
                .AlignCenter()
                .AlignMiddle();
        }
    }
}
