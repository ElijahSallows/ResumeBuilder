using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.ConsoleTesting.Models
{
    internal class DocumentTheme
    {
        public ColorModel Colors { get; set; }

        public float TopLineSize { get; set; }
        public float NameSize { get; set; }
        public float Spacing { get; set; }
        public float AddressEmailTextSize { get; set; }

        public DocumentTheme(ColorModel colors,
            float topLineSize = 50,
            float nameSize = 36,
            float spacing = 2,
            float addressEmailTextSize = 16)
        {
            Colors = colors;
            TopLineSize = topLineSize;
            NameSize = nameSize;
            Spacing = spacing;
            AddressEmailTextSize = addressEmailTextSize;
        }
    }
}
