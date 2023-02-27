using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using ResumeBuilder.Shared.Interfaces;
using ResumeBuilder.Shared.Models;

namespace ResumeBuilder.ConsoleTesting.Components
{
    internal class ContactComponent : IComponent
    {
        public IAddress Address { get; }
        public string Email { get; }
        public string Phone { get; }
        public IDocumentTheme Theme { get; }

        public ContactComponent(IAddress address, string email, string phone, IDocumentTheme theme)
        {
            Address = address;
            Email = email;
            Phone = phone;
            Theme = theme;
        }

        public void Compose(IContainer container)
        {
            container.AlignRight()
                .AlignTop()
                .ShowEntire()
                //.Background(Theme.Colors.Subfocus)
                .PaddingVertical(8f)
                .PaddingHorizontal(10f)
                .Column(column =>
            {
                column.Spacing(Theme.Spacing);

                column.Item()
                    .AlignRight()
                    .Text($"{Address.City}, {Address.State}")
                    .FontSize(Theme.ContactComponentTextSize)
                    .FontFamily(Theme.Fonts.Main);

                column.Item()
                    .AlignRight()
                    .Text(Email)
                    .FontSize(Theme.ContactComponentTextSize)
                    .FontFamily(Theme.Fonts.Main);

                column.Item()
                    .AlignRight()
                    .Text(Phone)
                    .FontSize(Theme.ContactComponentTextSize)
                    .FontFamily(Theme.Fonts.Main);
            });
        }
    }
}
