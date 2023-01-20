using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using ResumeBuilder.ConsoleTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            container.AlignLeft().Column(column =>
            {
                //column.Item().Grid
                column.Item().Inlined(inlined =>
                {
                    inlined.Spacing(5);
                    foreach (SocialLink link in Links)
                    {
                        inlined.Item().Element(element =>
                        {
                            //element.Hyperlink(link.Url).Image(link.ImageUri);
                            element.Hyperlink(link.Url).Text(link.Name);
                        });
                    }
                });
            });
        }
    }
}
