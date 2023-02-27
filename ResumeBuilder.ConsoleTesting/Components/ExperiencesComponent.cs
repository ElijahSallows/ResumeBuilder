using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.ConsoleTesting.Components
{
    internal class ExperiencesComponent : IComponent
    {
        private int _numberOfDisplayedExperiences;

        public List<IExperience> Experiences { get; set; }
        public IDocumentTheme Theme { get; set; }

        public ExperiencesComponent(List<IExperience> experiences, IDocumentTheme theme)
        {
            Experiences = experiences;
            Theme = theme;
        }

        public void Compose(IContainer container)
        {
            _numberOfDisplayedExperiences = Experiences.Count <= Theme.MaxExperienceCount ? Experiences.Count : Theme.MaxExperienceCount;

            container.Column(column =>
            {
                for (int i = 0; i < _numberOfDisplayedExperiences; i++)
                {
                    var component = new SingleExperienceComponent(Experiences[i], Theme);
                    column.Item()
                        .Component(component);
                }
            });
        }
    }
}
