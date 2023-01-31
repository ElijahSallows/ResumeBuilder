namespace ResumeBuilder.ConsoleTesting.Models
{
    internal class DocumentTheme
    {
        public ColorModel Colors { get; set; }

        public float TopLineSize { get; set; }
        public float NameSize { get; set; }
        public float Spacing { get; set; }
        public float ContactComponentTextSize { get; set; }
        public bool ContactMeTextVisible { get; set; }
        public float ImageSize { get; set; }

        public DocumentTheme(ColorModel colors,
            float topLineSize = 50,
            float nameSize = 36,
            float spacing = 2,
            float contactComponentTextSize = 16,
            bool contactMeTextVisible = false,
            float imageSize = 24)
        {
            Colors = colors;
            TopLineSize = topLineSize;
            NameSize = nameSize;
            Spacing = spacing;
            ContactComponentTextSize = contactComponentTextSize;
            ContactMeTextVisible = contactMeTextVisible;
            ImageSize = imageSize;
        }
    }
}
