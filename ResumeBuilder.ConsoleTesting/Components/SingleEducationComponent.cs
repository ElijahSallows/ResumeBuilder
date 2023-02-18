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
                !Education.Current && Education.EndDate.HasValue
                ? Education.EndDate.Value.ToString("MMM yyy")
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
                        .Text(Education.SchoolName)
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

                for (int i = 0; i < Education.Points.Count; i++)
                {
                    var point = Education.Points[i];
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
