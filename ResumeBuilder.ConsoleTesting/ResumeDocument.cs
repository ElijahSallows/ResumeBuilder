using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ResumeBuilder.ConsoleTesting.Components;
using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;
using System.Runtime.CompilerServices;

namespace ResumeBuilder.ConsoleTesting
{
    public class ResumeDocument : IDocument
    {
        public IResumeInfoModel Info { get; }
        public IDocumentTheme Theme { get; }

        public ResumeDocument(IResumeInfoModel info, IDocumentTheme theme)
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
                //page.PageColor(Theme.Colors.Secondary);
                page.Background()
                    .BorderVertical(5)
                    .BorderColor(Theme.Colors.Main)
                    .BorderHorizontal(10)
                    .BorderColor(Theme.Colors.Main);

                page.Header()
                    .AlignTop()
                    .Background(Theme.Colors.Background)
                    .Element(ComposeHeader);

                page.Content()
                    .Background(Theme.Colors.Background)
                    .Element(ComposeContent);

                page.Footer()
                    .AlignBottom()
                    .Background(Theme.Colors.BottomContrast)
                    .Element(ComposeFooter);
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
                    .MinHeight(20)
                    //.PaddingBottom(40f)
                    .PaddingTop(6f)
                    //.PaddingLeft(10f)
                    .AlignCenter()
                    .Text(Info.User.Name)
                    .FontSize(Theme.NameSize)
                    .FontColor(Theme.Colors.Main);

                table.Cell()
                    .Column(1)
                    .Row(3)
                    .PaddingBottom(10f)
                    //.PaddingHorizontal(20f)
                    .AlignCenter()
                    .Text(Info.User.Title)
                    .FontSize(Theme.ContactComponentTextSize)
                    .FontColor(Theme.Colors.Subfocus);

                table.Cell()
                    .Column(1)
                    .Row(4)
                    .ColumnSpan(3)
                    .BorderColor(Theme.Colors.DarkContrast)
                    .BorderTop(Theme.BorderHorizontalThickness);

                table.Cell()
                    .Column(1)
                    .ColumnSpan(3)
                    .Row(4)
                    .PaddingBottom(10f)
                    .AlignTop()
                    .AlignCenter()
                    .Text(Info.User.About)
                    .FontFamily(Theme.Fonts.Main)
                    .FontSize(Theme.AboutTextSize);

                table.Cell()
                    .Column(1)
                    .ColumnSpan(3)
                    .Row(5)
                    .AlignBottom()
                    .Background(Theme.Colors.LightContrast)
                    .BorderColor(Theme.Colors.DarkContrast)
                    .BorderVertical(Theme.BorderVerticalThickness)
                    .BorderHorizontal(Theme.BorderHorizontalThickness)
                    .PaddingVertical(2f)
                    .Component(socials);

                // Right side. Contains rough idea of where User lives as well as contact info.
                var addressEmail =
                    new ContactComponent(Info.User.Address,
                    Info.User.Email,
                    Info.User.Phone,
                    Theme);


                table.Cell()
                    .Column(3)
                    .RowSpan(4)
                    .Component(addressEmail);
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
                    .Text("")//$"{Info.User.Phone} - {Info.User.Email}")
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
                    columns.ConstantColumn(10f);
                    columns.RelativeColumn();
                });

                // Section headers
                table.Cell()
                    .Row(2)
                    .Column(1)
                    .Element(StyleSectionHeader)
                    .Text("Skills");
                table.Cell()
                    .Row(4)
                    .Column(1)
                    .Element(StyleSectionHeader)
                    .Text("Experiences");
                table.Cell()
                    .Row(2)
                    .Column(3)
                    .Element(StyleSectionHeader)
                    .Text("Featured Projects");
                table.Cell()
                    .Row(4)
                    .Column(3)
                    .Element(StyleSectionHeader)
                    .Text("Education");

                // Component declarations
                var skillsComponent = new SkillsComponent(Info.Skills.Bullets, Theme);
                var projectsComponent = new ProjectsComponent(Info.Projects, Theme);
                var experiencesComponent = new ExperiencesComponent(Info.Experiences, Theme);
                var educationComponent = new EducationsComponent(Info.Education, Theme);

                // Main components

                // Skills
                table.Cell()
                    .Row(3)
                    .Column(1)
                    .Element(StyleSectionBody)
                    .Component(skillsComponent);
                // Projects
                table.Cell()
                    .Row(5)
                    .Column(1)
                    .ExtendVertical()
                    .Element(StyleSectionBody)
                    .Component(experiencesComponent);

                // Experiences
                table.Cell()
                    .Row(3)
                    .Column(3)
                    .Element(StyleSectionBody)
                    .Component(projectsComponent);
                // Education
                table.Cell()
                    .Row(5)
                    .Column(3)
                    .ExtendVertical()
                    .Element(StyleSectionBody)
                    .Component(educationComponent);
            });
        }

        private IContainer StyleSectionBody(IContainer container)
        {
            return
                container.Background(Theme.Colors.LightContrast);
            //.BorderVertical(Theme.BorderVerticalThickness);
        }

        // Styling methods (used in .Element() calls)
        private IContainer StyleSectionHeader(IContainer container)
        {
            var textStyle = new TextStyle();

            textStyle = textStyle
                .FontColor(Colors.White)
                .FontSize(Theme.ContactComponentTextSize);

            return container.DefaultTextStyle(textStyle)
                //.ExtendHorizontal()
                .Background(Theme.Colors.Main)
                .BorderColor(Theme.Colors.Background)
                //.Border(3)
                .AlignCenter()
                .AlignMiddle();
        }
    }
}
