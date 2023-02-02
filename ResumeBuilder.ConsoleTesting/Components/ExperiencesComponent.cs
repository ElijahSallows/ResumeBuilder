using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ResumeBuilder.ConsoleTesting.Models;

namespace ResumeBuilder.ConsoleTesting.Components
{
    internal class ExperiencesComponent : IComponent
    {
        private int _numberOfDisplayedExperiences;

        public List<Experience> Experiences { get; set; }
        public DocumentTheme Theme { get; set; }

        public ExperiencesComponent(List<Experience> experiences, DocumentTheme theme)
        {
            Experiences = experiences;
            Theme = theme;
        }

        public void Compose(IContainer container)
        {
            _numberOfDisplayedExperiences = Experiences.Count <= Theme.MaxExperienceCount ? Experiences.Count : Theme.MaxExperienceCount;
            //debug. might look into debug methods in questpdf.
            var colors = new List<string>()
            {
                Colors.Pink.Medium,
                Colors.Amber.Medium,
                Colors.Green.Lighten1,
                Colors.Cyan.Medium,
                Colors.Yellow.Medium
            };

            container.Column(column =>
            {
                for (int i = 0; i < _numberOfDisplayedExperiences; i++)
                {
                    var component = new SingleExperienceComponent(Experiences[i], Theme);
                    column.Item().Background(colors[i]).Component(component);
                }
            });
        }
    }
}
