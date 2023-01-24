using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using ResumeBuilder.ConsoleTesting.Models;

namespace ResumeBuilder.ConsoleTesting.Components
{
    internal class ContactComponent : IComponent
    {
        public Address Address { get; }
        public string Email { get; }
        public string Phone { get; }
        public DocumentTheme Theme { get; }

        public ContactComponent(Address address, string email, string phone, DocumentTheme theme)
        {
            Address = address;
            Email = email;
            Phone = phone;
            Theme = theme;
        }

        public void Compose(IContainer container)
        {
            container.AlignRight().AlignBottom().ShowEntire().Column(column =>
            {
                column.Spacing(Theme.Spacing);

                column.Item().AlignRight().Text(Address.City)
                .FontSize(Theme.ContactComponentTextSize);

                column.Item().AlignRight().Text($"{Address.State}  {Address.Zip}")
                .FontSize(Theme.ContactComponentTextSize);

                column.Item().AlignRight().Text(Email)
                .FontSize(Theme.ContactComponentTextSize);

                column.Item().AlignRight().Text(Phone)
                .FontSize(Theme.ContactComponentTextSize);
            });
        }
    }
}
