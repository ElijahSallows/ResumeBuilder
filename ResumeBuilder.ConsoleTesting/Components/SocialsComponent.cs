using QuestPDF.Fluent;
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
            container.Table(table =>
                {
                    // Max of links
                    // Will likely either change or limit amount that can be put in.
                    int amtLinks = Links.Count > 6 ? 6 : Links.Count;
                    //bool secondColumn = Links.Count > 3;

                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn();
                        //if (secondColumn)
                        //{
                        //    columns.RelativeColumn();
                        //}
                    });

                    for (int i = 0; i < amtLinks; i++)
                    {
                        // socialComponent has to account for the difference in indexing
                        var socialComponent = new SingleSocialComponent(Links[i], Theme);

                        // QuestPDF uses a 1-based index system, unlike C#. Account for that here.
                        uint row = (uint)i % 3 + 1;
                        //uint column = (uint)i / 3 + 1;

                        table.Cell()
                            .Row(row)
                            //.Column(column)
                            .PaddingVertical(1f)
                            .AlignLeft()
                            //.Background(Colors.Cyan.Medium)
                            .Component(socialComponent);
                    }
                });
        }
    }
}
