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
    internal class AddressEmailComponent : IComponent
    {
        public Address Address { get; }
        public string Email { get; }
        public DocumentTheme Theme { get; }

        public AddressEmailComponent(Address address, string email, DocumentTheme theme)
        {
            Address = address;
            Email = email;
            Theme = theme;
        }

        public void Compose(IContainer container)
        {
            container.AlignRight().AlignBottom().ShowEntire().Column(column =>
            {
                column.Spacing(Theme.Spacing);

                column.Item().AlignRight().Text(Address.City)
                .FontSize(Theme.AddressEmailTextSize);

                column.Item().AlignRight().Text($"{Address.State}  {Address.Zip}")
                .FontSize(Theme.AddressEmailTextSize);

                column.Item().AlignRight().Text(Email)
                .FontSize(Theme.AddressEmailTextSize);
            });
        }
    }
}
