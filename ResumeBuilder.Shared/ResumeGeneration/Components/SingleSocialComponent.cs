using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.Shared.ResumeGeneration.Components
{
    internal class SingleSocialComponent : IComponent
    {
        public SocialLink Link { get; set; }
        public DocumentTheme Theme { get; set; }

        public SingleSocialComponent(SocialLink link, DocumentTheme theme)
        {
            Link = link;
            Theme = theme;
        }

        public void Compose(IContainer container)
        {
            container.AlignMiddle()
                .Row(row =>
            {
                //row.AutoItem()
                //    .PaddingRight(2)
                //    .Width(Theme.ImageSize)
                //    .Height(Theme.ImageSize)
                //    .MinimalBox()
                //    .Hyperlink(Link.Url)
                //    .Image(Link.Image);
                row.RelativeItem()
                    .AlignCenter()
                    .AlignMiddle()
                    .PaddingLeft(2)
                    .Hyperlink(Link.Url)
                    .Text(Link.Url) //.Name
                    .FontSize(Theme.ContactComponentTextSize * .9f);
            });
        }
    }
}
