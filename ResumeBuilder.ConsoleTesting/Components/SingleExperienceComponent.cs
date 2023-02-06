using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ResumeBuilder.ConsoleTesting.Models;

namespace ResumeBuilder.ConsoleTesting.Components
{
    internal class SingleExperienceComponent : IComponent
    {
        public Experience Experience { get; set; }
        public DocumentTheme Theme { get; set; }

        public SingleExperienceComponent(Experience experience, DocumentTheme theme)
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
                    header.Cell().ColumnSpan(3).Background(Theme.Colors.Secondary);

                    header.Cell()
                    .Column(1)
                    .ColumnSpan(2)
                    .AlignLeft()
                    .AlignMiddle()
                    .Text(Experience.CompanyName)
                    .FontSize(Theme.ExperienceCompanyNameTextSize);

                    header.Cell()
                    .Column(3)
                    .AlignRight()
                    .AlignMiddle()
                    .Text($"{_startDate} - {_endDate}")
                    .FontSize(Theme.ExperienceTimeTextSize);
                });

                for (int i = 0; i < Experience.Points.Count; i++)
                {
                    var point = Experience.Points[i];
                    table.Cell()
                        .Row((uint)i + 2)
                        .ColumnSpan(3)
                        .PaddingRight(2f)
                        .Text(">  " + point)
                        .FontSize(Theme.ExperienceTextSize)
                        .FontFamily(Theme.Fonts.Main);
                }
            });
        }
    }
}
