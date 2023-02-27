using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.ConsoleTesting.Components
{
    internal class ProjectsComponent : IComponent
    {
        private int _numberOfDisplayedProjects;

        public List<IProject> Projects { get; set; }
        public IDocumentTheme Theme { get; }

        public ProjectsComponent(List<IProject> projects, IDocumentTheme theme)
        {
            Projects = projects;
            Theme = theme;
        }


        public void Compose(IContainer container)
        {
            _numberOfDisplayedProjects = Projects.Count <= Theme.MaxProjectCount ? Projects.Count : Theme.MaxProjectCount;

            container.Column(column =>
            {
                for (int i = 0; i < _numberOfDisplayedProjects; i++)
                {
                    var component = new SingleProjectComponent(Projects[i], Theme);
                    column.Item()
                        //.Background(colors[i])
                        .Component(component);
                }
            });

            //container.Table(table =>
            //{
            //    table.ColumnsDefinition(columns =>
            //    {
            //        columns.RelativeColumn();
            //        columns.RelativeColumn();
            //        columns.RelativeColumn();
            //    });

            //    table.Cell()
            //        .Column()
            //        .Row()

            //});
        }
    }
}
