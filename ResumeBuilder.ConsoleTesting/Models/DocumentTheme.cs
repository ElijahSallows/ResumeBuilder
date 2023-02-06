namespace ResumeBuilder.ConsoleTesting.Models
{
    internal class DocumentTheme
    {
        public ColorModel Colors { get; set; }
        public FontModel Fonts { get; set; }
        public string Bullet { get; set; } = "•";

        public float TopLineSize { get; set; }
        public float NameSize { get; set; }
        public float Spacing { get; set; }
        public float SkillSpacing { get; set; }

        public float AboutTextSize { get; set; }
        public float ContactComponentTextSize { get; set; }
        public float SkillTextSize { get; set; }
        public float ExperienceCompanyNameTextSize { get; set; }
        public float ExperienceTextSize { get; set; }
        public float ExperienceTimeTextSize { get; set; }

        public bool ContactMeTextVisible { get; set; }
        public float ImageSize { get; set; }

        public int SkillsColumnCount { get; set; }
        public int MaxSkillCount { get; set; }
        public int MaxExperienceCount { get; set; }

        public float BorderVerticalThickness { get; set; }
        public float BorderHorizontalThickness { get; set; }

        public DocumentTheme(ColorModel colors,
            FontModel fonts,
            float topLineSize = 50,
            float nameSize = 36f,
            float spacing = 2,
            float skillSpacing = 2f,
            float aboutTextSize = 14f,
            float contactComponentTextSize = 16f,
            float skillTextSize = 14f,
            float experienceCompanyNameTextSize = 14f,
            float experienceTextSize = 12f,
            float experienceTimeTextSize = 8f,
            bool contactMeTextVisible = false,
            float imageSize = 24f,
            int skillsColumnCount = 3,
            int maxSkillCount = 24,
            int maxExperienceCount = 3,
            float borderVerticalThickness = 1f,
            float borderHorizontalThickness = 1f)
        {
            Colors = colors;
            Fonts = fonts;
            TopLineSize = topLineSize;
            NameSize = nameSize;
            Spacing = spacing;
            SkillSpacing = skillSpacing;
            AboutTextSize = aboutTextSize;
            ContactComponentTextSize = contactComponentTextSize;
            SkillTextSize = skillTextSize;
            ExperienceCompanyNameTextSize = experienceCompanyNameTextSize;
            ExperienceTextSize = experienceTextSize;
            ExperienceTimeTextSize = experienceTimeTextSize;
            ContactMeTextVisible = contactMeTextVisible;
            ImageSize = imageSize;
            SkillsColumnCount = skillsColumnCount;
            MaxSkillCount = maxSkillCount;
            MaxExperienceCount = maxExperienceCount;
            BorderVerticalThickness = borderVerticalThickness;
            BorderHorizontalThickness = borderHorizontalThickness;
        }
    }
}
