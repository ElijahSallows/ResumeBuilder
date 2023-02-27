using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.ConsoleTesting.Components
{
    internal class SingleSocialComponent : IComponent
    {
        public ISocialLink Link { get; set; }
        public IDocumentTheme Theme { get; set; }

        public SingleSocialComponent(ISocialLink link, IDocumentTheme theme)
        {
            Link = link;
            Theme = theme;
        }

        public void Compose(IContainer container)
        {
            container.AlignCenter()
                .AlignMiddle()
                .Row(row =>
            {
                row.RelativeItem()
                    .AlignRight()
                    .MinimalBox()
                    .PaddingRight(2)
                    .Width(Theme.ImageSize)
                    .Height(Theme.ImageSize)
                    .Image(Link.Image);
                row.RelativeItem()
                    .AlignLeft()
                    .AlignMiddle()
                    .PaddingLeft(2)
                    .Hyperlink(Link.Url)
                    .Text(Link.Name)
                    .FontSize(Theme.ContactComponentTextSize * .9f)
                    //.FontColor(Theme.Colors.Background)
                    .FontFamily(Theme.Fonts.Social);
            });
        }
    }
}
