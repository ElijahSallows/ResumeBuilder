using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.ConsoleTesting.Components
{
    internal class SingleExperienceComponent : IComponent
    {
        public IExperience Experience { get; set; }
        public IDocumentTheme Theme { get; set; }

        public SingleExperienceComponent(IExperience experience, IDocumentTheme theme)
        {
            Experience = experience;
            Theme = theme;
        }

        public void Compose(IContainer container)
        {
            // Need to format before displaying.
            // I don't know whether this belongs somewhere separate yet.
            string _startDate = Experience.StartDate.ToString("MMM yyy");
            string _endDate =
                !Experience.Current && Experience.EndDate.HasValue
                ? Experience.EndDate.Value.ToString("MMM yyy")
                : "Current";

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
                        .ColumnSpan(3)
                        .Background(Theme.Colors.MediumContrast);

                    header.Cell()
                        .Column(1)
                        .ColumnSpan(2)
                        .AlignLeft()
                        .AlignMiddle()
                        .PaddingLeft(Theme.ExperienceSpacing)
                        .Text(Experience.CompanyName)
                        .FontSize(Theme.ExperienceCompanyNameTextSize);

                    header.Cell()
                        .Column(3)
                        .AlignRight()
                        .AlignMiddle()
                        .PaddingRight(Theme.ExperienceSpacing)
                        .Text($"{_startDate} - {_endDate}")
                        .FontSize(Theme.ExperienceTimeTextSize);
                    header.Cell()
                        .ColumnSpan(3)
                        .PaddingHorizontal(10f)
                        .BorderColor(Theme.Colors.DarkContrast)
                        .BorderBottom(1f);
                });

                for (int i = 0; i < Experience.Points.Count; i++)
                {
                    var point = Experience.Points[i];
                    table.Cell()
                        .Row((uint)i + 2)
                        .ColumnSpan(3)
                        .PaddingLeft(5f)
                        .PaddingRight(2f)
                        .PaddingBottom(Theme.ExperienceSpacing)
                        .Text(">  " + point)
                        .FontSize(Theme.ExperienceTextSize)
                        .FontFamily(Theme.Fonts.Main);
                }
            });
        }
    }
}
