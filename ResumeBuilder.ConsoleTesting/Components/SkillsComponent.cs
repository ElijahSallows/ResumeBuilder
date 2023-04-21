using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.ConsoleTesting.Components
{
    internal class SkillsComponent : IComponent
    {
        private int _numberOfDisplayedSkills;

        public List<Skill> Skills { get; set; }
        public DocumentTheme Theme { get; set; }

        public SkillsComponent(List<Skill> skills, DocumentTheme theme)
        {
            Skills = skills;
            Theme = theme;
        }

        public void Compose(IContainer container)
        {
            _numberOfDisplayedSkills = Skills.Count <= Theme.MaxSkillCount ? Skills.Count : Theme.MaxSkillCount;

            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    for (int i = 0; i < Theme.SkillsColumnCount; i++)
                    {
                        columns.RelativeColumn();
                    }
                });

                for (int i = 0; i < _numberOfDisplayedSkills; i++) // (Skill skill in Skills)
                {
                    table.Cell()
                        .Column(GetColumnPosition(i))
                        .Row(GetRowPosition(i))
                        .PaddingBottom(Theme.SkillSpacing)
                        .AlignCenter()
                        .Text($"{Theme.Bullet}   {Skills[i].Name}")
                        .FontSize(Theme.SkillTextSize);
                    //.Row(row =>
                    //{ 

                    //    row.RelativeItem()
                    //        .AlignRight()
                    //        .Text(Theme.Bullet)
                    //        .FontSize(Theme.SkillTextSize);

                    //    row.ConstantItem(10f);

                    //    row.RelativeItem(2f)
                    //        .Text(Skills[i].Name)
                    //        .FontSize(Theme.SkillTextSize);

                    //});
                }
            });
        }

        private uint GetColumnPosition(int i)
        {
            int posZero = Convert.ToInt32(i) % Theme.SkillsColumnCount;
            uint columnPosition = Convert.ToUInt32(posZero + 1); // Add 1 because QuestPDF uses 1-based indexing.
            return columnPosition;
        }

        private uint GetRowPosition(int i)
        {
            decimal posZero = Math.Floor(Convert.ToDecimal(i) / Convert.ToDecimal(Theme.SkillsColumnCount));
            uint rowPosition = Convert.ToUInt32(posZero + 1); // Add 1 because QuestPDF uses 1-based indexing.
            return rowPosition;
        }
    }
}
