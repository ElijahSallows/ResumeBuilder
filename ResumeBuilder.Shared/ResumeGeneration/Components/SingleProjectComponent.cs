using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.Shared.ResumeGeneration.Components
{
    internal class SingleProjectComponent : IComponent
    {
        public Project Project { get; set; }
        public DocumentTheme Theme { get; set; }

        public SingleProjectComponent(Project project, DocumentTheme theme)
        {
            Project = project;
            Theme = theme;
        }

        public void Compose(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });
                table.Header(header =>
                {
                    header.Cell()
                        .ColumnSpan(3);
                        //.Background(Theme.Colors.MediumContrast);

                    header.Cell()
                        .Column(1)
                        .ColumnSpan(2)
                        .AlignLeft()
                        .AlignMiddle()
                        .PaddingLeft(Theme.ProjectSpacing)
                        .Text(Project.Name)
                        .FontSize(Theme.ProjectNameTextSize);

                    header.Cell()
                        .Column(3)
                        .AlignRight()
                        .AlignMiddle()
                        .PaddingRight(Theme.ProjectSpacing)
                        .Text(Project.Date)
                        .FontSize(Theme.ProjectTimeTextSize);
                    header.Cell()
                        .ColumnSpan(3)
                        .PaddingHorizontal(10f)
                        .BorderColor(Theme.Colors.Main)
                        .BorderBottom(1f);
                });

                for (int i = 0; i < Project.Points.Count; i++)
                {
                    var point = Project.Points[i];
                    table.Cell()
                        .Row((uint)i + 2)
                        .ColumnSpan(3)
                        .PaddingLeft(5f)
                        .PaddingRight(2f)
                        .PaddingBottom(Theme.ProjectSpacing)
                        .Text(">  " + point)
                        .FontSize(Theme.ProjectTextSize)
                        .FontFamily(Theme.Fonts.Main);
                }
            });
        }
    }
}
