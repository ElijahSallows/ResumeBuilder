namespace ResumeBuilder.ConsoleTesting.Models
{
    internal class DocumentTheme
    {
        public ColorModel Colors { get; set; }

        public float TopLineSize { get; set; }
        public float NameSize { get; set; }
        public float Spacing { get; set; }
        public float ContactComponentTextSize { get; set; }

        public DocumentTheme(ColorModel colors,
            float topLineSize = 50,
            float nameSize = 36,
            float spacing = 2,
            float contactComponentTextSize = 16)
        {
            Colors = colors;
            TopLineSize = topLineSize;
            NameSize = nameSize;
            Spacing = spacing;
            ContactComponentTextSize = contactComponentTextSize;
        }
    }
}
