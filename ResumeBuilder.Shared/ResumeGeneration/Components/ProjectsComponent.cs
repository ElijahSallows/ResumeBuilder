using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.Shared.ResumeGeneration.Components
{
    internal class ProjectsComponent : IComponent
    {
        private int _numberOfDisplayedProjects;

        public List<Project> Projects { get; set; }
        public DocumentTheme Theme { get; }

        public ProjectsComponent(List<Project> projects, DocumentTheme theme)
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
