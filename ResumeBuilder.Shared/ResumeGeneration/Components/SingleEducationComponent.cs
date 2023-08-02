using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.Shared.ResumeGeneration.Components
{
    internal class SingleEducationComponent : IComponent
    {
        public Education Education { get; set; }
        public DocumentTheme Theme { get; set; }

        public SingleEducationComponent(Education education, DocumentTheme theme)
        {
            Education = education;
            Theme = theme;
        }

        public void Compose(IContainer container)
        {
            string _startDate = Education.StartDate.ToString("MMM yyy");
            string _endDate =
                !Education.Current
                ? Education.EndDate.ToString("MMM yyy")
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
                        .ColumnSpan(3);
                        //.Background(Theme.Colors.MediumContrast);

                    header.Cell()
                        .Column(1)
                        .ColumnSpan(2)
                        .AlignLeft()
                        .AlignMiddle()
                        .PaddingLeft(Theme.EducationSpacing)
                        .Text(Education.SchoolName)
                        .FontSize(Theme.EducationSchoolNameTextSize);

                    header.Cell()
                        .Column(3)
                        .AlignRight()
                        .AlignMiddle()
                        //.PaddingRight(Theme.EducationSpacing)
                        .Text($"{_startDate} - {_endDate}")
                        .FontSize(Theme.EducationTimeTextSize);
                    header.Cell()
                        .ColumnSpan(3)
                        .PaddingHorizontal(10f)
                        .BorderColor(Theme.Colors.Main)
                        .BorderBottom(1f);
                });

                for (int i = 0; i < Education.Points.Count; i++)
                {
                    var point = Education.Points[i];
                    table.Cell()
                        .Row((uint)i + 2)
                        .ColumnSpan(3)
                        .PaddingLeft(5f)
                        .PaddingRight(2f)
                        .PaddingBottom(Theme.EducationSpacing)
                        .Text($"{Theme.Bullet}   {point}")
                        .FontSize(Theme.EducationTextSize)
                        .FontFamily(Theme.Fonts.Main);
                }
            });
        }
    }
}
