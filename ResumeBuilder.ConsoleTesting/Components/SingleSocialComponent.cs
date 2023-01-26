using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using ResumeBuilder.ConsoleTesting.Models;

namespace ResumeBuilder.ConsoleTesting.Components
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
            container.AlignCenter().AlignMiddle().Row(row =>
            {
                //row.RelativeItem()
                //    .AlignRight()
                //    .MinimalBox()
                //    .PaddingRight(2)
                //    .Image(Link.ImageUri);
                    //.Width(32)
                    //.Height(32)
                    //.Placeholder();//.Image(Link.ImageUri);
                row.RelativeItem()
                    .AlignLeft()
                    .AlignMiddle()
                    .PaddingLeft(2)
                    .Hyperlink(Link.Url)
                    .Text(Link.Name)
                    .FontSize(Theme.ContactComponentTextSize * .9f);
            });
        }
    }
}
