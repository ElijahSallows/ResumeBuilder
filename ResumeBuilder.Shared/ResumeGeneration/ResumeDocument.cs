using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ResumeBuilder.Shared.Models;
using ResumeBuilder.Shared.ResumeGeneration.Components;

namespace ResumeBuilder.Shared.ResumeGeneration
{
    public class ResumeDocument : IDocument
    {
        public ResumeInfoModel Info { get; }
        public DocumentTheme Theme { get; }

        public ResumeDocument(ResumeInfoModel info, DocumentTheme theme)
        {
            Info = info;
            Theme = theme;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.Letter);

                page.MarginHorizontal(20f);

                TextStyle textStyle = new();
                textStyle.FontFamily(Theme.Fonts.Main);
                page.DefaultTextStyle(textStyle);

                //page.PageColor(Theme.Colors.Secondary);
                //page.Background()
                //    //.BorderVertical(5)
                //    //.BorderColor(Theme.Colors.Main)
                //    .BorderTop(30f)
                //    .BorderColor(Theme.Colors.Main);

                // Main Resume Document
                page.Content().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn();
                    });

                    //TextStyle whiteText = new();
                    //whiteText = whiteText.FontColor(Theme.Colors.Main)
                    //    .Bold();

                    table.Cell()
                        .RowSpan(3)
                        .AlignTop()
                        //.Background(Theme.Colors.Main)
                        //.DefaultTextStyle(whiteText)
                        .Element(ComposeHeader);

                    table.Cell()
                        .Row(4)
                        .RowSpan(6)
                        .Background(Theme.Colors.Background)
                        .Element(ComposeContent);

                    //table.Cell()
                    //    .Row(10)
                    //    .RowSpan(1)
                    //    .Background(Theme.Colors.BottomContrast)
                    //    .Element(ComposeFooter);
                });
                //page.Header()
                //    .AlignTop()

                //    .Background(Theme.Colors.Background)
                //    .Element(ComposeHeader);

                //page.Content()
                //    .Background(Theme.Colors.Background)
                //    .Element(ComposeContent);

                //page.Footer()
                //    .AlignBottom()
                //    .Background(Theme.Colors.BottomContrast)
                //    .Element(ComposeFooter);
            });
        }

        public void ComposeHeader(IContainer container)
        {
            var info = Info.User.Info;
            float headerWidth = PageSizes.Letter.Width - 20f;

            bool displaySocials = info.Links.Count != 0;

            container.MaxHeight(PageSizes.Letter.Height * 3f / 10f)
                //.Width(headerWidth * 0.75f)
                //.Background(Colors.Black)
                .AlignCenter()
                .Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn();
                        columns.RelativeColumn();
                    });

                    table.Cell()
                        //.ColumnSpan(3)
                        .PaddingBottom(10f)
                        .Column(column =>
                        {

                            column.Item()
                                .AlignCenter()
                                .Text(info.Name)
                                .FontSize(Theme.NameSize)
                                .FontColor(Theme.Colors.Main)
                                .Bold();

                            column.Item()
                                .AlignCenter()
                                .Text(info.Title)
                                .FontSize(Theme.TitleSize)
                                .Bold();
                        });

                    table.Cell()
                        .ColumnSpan(2)
                        .Row(2)
                        //.MaxWidth(headerWidth * 0.5f)
                        .AlignCenter()
                        .MinimalBox()
                        .PaddingBottom(10f)
                        //.Background(Colors.Cyan.Darken3)
                        .Column(about =>
                        {
                            about.Item()
                                .MinimalBox()
                                .AlignCenter()
                                //.Background(Colors.LightBlue.Lighten3)
                                .Text(info.About)
                                .FontSize(Theme.AboutTextSize)
                                .Bold();

                        });

                    var contact = new ContactComponent(Info.Address.Info, info.Email, info.Phone, Theme);
                    table.Cell()
                        .Column(2)
                        .Component(contact);

                    if (displaySocials)
                    {
                        var socials = new SocialsComponent(Info.User.Info.Links, Theme);
                        table.Cell()
                            .ColumnSpan(2)
                            .Row(3)
                            .AlignCenter()
                            .AlignBottom()
                            .Component(socials);
                    }

                    /*column.Item()
                    .AlignCenter()
                    .AlignBottom()
                    .Background(Theme.Colors.Secondary)
                    .Component(socials);




                 Left side. User's name.
                var socials = new SocialsComponent(Info.User.Info.Links, Theme);

                table.Cell()
                    .Column(1)
                    .Row(1)
                    .RowSpan(2)
                    .MinHeight(20)
                    //.PaddingBottom(40f)
                    .PaddingTop(6f)
                    //.PaddingLeft(10f)
                    .AlignCenter()
                    .Text(Info.User.Info.Name)
                    .FontSize(Theme.NameSize)
                    .FontColor(Theme.Colors.Main);

                table.Cell()
                    .Column(1)
                    .Row(3)
                    .PaddingBottom(10f)
                    //.PaddingHorizontal(20f)
                    .AlignCenter()
                    .Text(Info.User.Info.Title)
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
                    .Text(Info.User.Info.About)
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
                    new ContactComponent(Info.Address.Info,
                    Info.User.Info.Email,
                    Info.User.Info.Phone,
                    Theme);


                table.Cell()
                    .Column(3)
                    .RowSpan(4)
                    .Component(addressEmail);*/
                });
        }

        public void ComposeContent(IContainer container)
        {

            // Component declarations
            var skillsComponent = new SkillsComponent(Info.Skills.Info, Theme);
            var projectsComponent = new ProjectsComponent(Info.Projects.Info, Theme);
            var experiencesComponent = new ExperiencesComponent(Info.Experiences.Info, Theme);
            var educationComponent = new EducationsComponent(Info.Education.Info, Theme);

            container//.PaddingTop(10f)
                .MaxHeight(PageSizes.Letter.Height * 7f / 10f)
                .Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(2f);
                        columns.RelativeColumn(3f);
                    });

                    table.ExtendLastCellsToTableBottom();


                    #region Sections
                    table.Cell()
                        //.PaddingRight(5f)
                        .Column(column =>
                        {
                            column.Item()
                                .Element(StyleSectionHeader)
                                .Text("> Skills");

                            column.Item()
                                .Element(StyleSectionBody)
                                .Component(skillsComponent);

                            column.Item()
                                .Element(StyleSectionHeader)
                                .Text("> Education");


                            column.Item()
                                .Element(StyleSectionBody)
                                .Component(educationComponent);
                        });

                    table.Cell()
                        .Column(2)
                        .PaddingLeft(10f)
                        .Column(column =>
                        {
                            column.Item()
                                .Element(StyleSectionHeader)
                                .Text("> Experience");


                            column.Item()
                                .Element(StyleSectionBody)
                                .Component(experiencesComponent);

                            column.Item()
                                .Element(StyleSectionHeader)
                                .Text("> Projects");


                            column.Item()
                                .Element(StyleSectionBody)
                                .Component(projectsComponent);
                        });
                    #endregion
                });
        }

        /*public void ComposeFooter(IContainer container)
        {
            var socials = new SocialsComponent(Info.User.Info.Links, Theme);

            container.Height(PageSizes.Letter.Height / 10f)
                .Column(column =>
            {


                // I'll need to find a way to streamline this.
                // I think I can set it as .Element() or something.
                column.Item()
                    .PaddingHorizontal(5f)
                    .Component(socials);

                //table.Cell()
                //    .Row(2)
                //    .Column(2)
                //    .ColumnSpan(2)
                //    .AlignMiddle()
                //    .AlignCenter()//.PaddingRight(10)
                //    .Text("")//$"{Info.User.Phone} - {Info.User.Email}")
                //    .FontColor(Colors.White)
                //    .FontSize(Theme.ContactComponentTextSize);

                
                //table.Cell().Row(2).Column(2).AlignMiddle().AlignRight().PaddingRight(10)
                //    .Text(Info.User.Phone)
                //    .FontColor(Colors.White)
                //    .FontSize(Theme.ContactComponentTextSize);

                //table.Cell().Row(2).Column(3).AlignMiddle().AlignLeft().PaddingRight(10)
                //    .Text(Info.User.Email)
                //    .FontColor(Colors.White)
                //    .FontSize(Theme.ContactComponentTextSize);
                
            });
        }*/

        private IContainer StyleSectionBody(IContainer container)
        {
            return
                container.PaddingLeft(4f);//.Background(Theme.Colors.LightContrast);
            //.BorderVertical(Theme.BorderVerticalThickness);
        }

        // Styling methods (used in .Element() calls)
        private IContainer StyleSectionHeader(IContainer container)
        {
            var textStyle = new TextStyle();

            textStyle = textStyle
                .FontColor(Theme.Colors.Main)
                .FontFamily(Theme.Fonts.Main)
                .FontSize(24f)
                .Bold();

            return container.DefaultTextStyle(textStyle)
                .PaddingTop(8f)
                .PaddingBottom(2f);

            //textStyle = textStyle
            //    .FontColor(Colors.White)
            //    .FontSize(Theme.ContactComponentTextSize);

            //return container.DefaultTextStyle(textStyle)
            //    //.ExtendHorizontal()
            //    .Background(Theme.Colors.Main)
            //    .BorderColor(Theme.Colors.Main)
            //    .BorderTop(2f)
            //    .AlignCenter()
            //    .AlignMiddle();
        }
    }
}
