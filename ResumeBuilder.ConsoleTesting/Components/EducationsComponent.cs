using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.ConsoleTesting.Components
{
    internal class EducationsComponent : IComponent
    {
        private int _numberOfDisplayedEducations;

        public List<IEducation> Educations { get; set; }
        public IDocumentTheme Theme { get; set; }

        public EducationsComponent(List<IEducation> educations, IDocumentTheme theme)
        {
            Educations = educations;
            Theme = theme;
        }

        public void Compose(IContainer container)
        {
            _numberOfDisplayedEducations = Educations.Count <= Theme.MaxEducationCount ? Educations.Count : Theme.MaxEducationCount;

            container.Column(column =>
            {
                for (int i = 0; i < _numberOfDisplayedEducations; i++)
                {
                    var component = new SingleEducationComponent(Educations[i], Theme);
                    column.Item()
                        .Component(component);
                }
            });
        }
    }
}
