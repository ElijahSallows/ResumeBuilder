using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using ResumeBuilder.ConsoleTesting.Models;

namespace ResumeBuilder.ConsoleTesting.Components
{
    internal class SkillsComponent : IComponent
    {
        public List<Skill> Skills { get; set; }
        public DocumentTheme Theme { get; set; }

        public SkillsComponent(List<Skill> skills, DocumentTheme theme)
        {
            Skills = skills;
            Theme = theme;
        }
        public void Compose(IContainer container)
        {
            container.Column(column =>
            {
                column.Spacing(0f);
                foreach (Skill skill in Skills)
                {
                    column.Item().Row(row =>
                    {
                        row.RelativeItem()
                            .AlignRight()
                            .Text("*")
                            .FontSize(20f);

                        row.ConstantItem(20f);

                        row.RelativeItem(2f)
                            .Text(skill.Name)
                            .FontSize(16f);
                    });
                }
            });
        }

        public IContainer ComposeBulletPoint(IContainer container)
        {
            return container;
        }
    }
}
