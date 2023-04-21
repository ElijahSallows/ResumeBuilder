using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.ConsoleTesting.Components
{
    internal class SocialsComponent : IComponent
    {
        public List<SocialLink> Links { get; }
        public DocumentTheme Theme { get; }

        public SocialsComponent(List<SocialLink> links, DocumentTheme theme)
        {
            Links = links;
            Theme = theme;
        }

        public void Compose(IContainer container)
        {
            container
                .AlignLeft()
                .AlignTop()
                .Table(table =>
                {
                    // Max of four columns (and therefore links)
                    // Will likely either change or limit amount that can be put in.
                    int amtColumn = Links.Count > 4 ? 3 : Links.Count;
                    table.ColumnsDefinition(columns =>
                    {
                        // Generate a column for each link (max of four)
                        for (int i = 0; i < amtColumn; i++)
                        {
                            columns.RelativeColumn();
                        }
                    });

                    // QuestPDF uses a 1-based index system, unlike C#. Account for that here.
                    for (int i = 1; i < amtColumn + 1; i++)
                    {
                        // comp has to account for the difference in indexing
                        var comp = new SingleSocialComponent(Links[i - 1], Theme);
                        // QuestPDF also requires .Column() to take in a uint as opposed to int. Casting, I suppose.
                        table.Cell()
                            .Column((uint)i)
                            //.Background(Colors.Cyan.Medium)
                            .Component(comp);
                    }
                });



            //    .Column(column =>
            //{
            //    //column.Item().Grid
            //    // I want a nice background
            //    column.Item().Inlined(inlined =>
            //    {
            //        inlined.Spacing(5);
            //        foreach (SocialLink link in Links)
            //        {
            //            inlined.Item().Element(element =>
            //            {
            //                //element.Hyperlink(link.Url).Image(link.Image);
            //                element.Hyperlink(link.Url).Text(link.Name);
            //            });
            //        }
            //    });
            //});
        }
    }
}
