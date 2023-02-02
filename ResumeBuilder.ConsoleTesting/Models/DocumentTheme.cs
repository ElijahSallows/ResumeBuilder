namespace ResumeBuilder.ConsoleTesting.Models
{
    internal class DocumentTheme
    {
        public ColorModel Colors { get; set; }
        public string Bullet { get; set; } = "•";

        public float TopLineSize { get; set; }
        public float NameSize { get; set; }
        public float Spacing { get; set; }

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

        public DocumentTheme(ColorModel colors,
            float topLineSize = 50,
            float nameSize = 36,
            float spacing = 2,
            float contactComponentTextSize = 16f,
            float skillTextSize = 12f,
            float experienceCompanyNameTextSize = 16f,
            float experienceTextSize = 12f,
            float experienceTimeTextSize = 8f,
            bool contactMeTextVisible = false,
            float imageSize = 24,
            int skillsColumnCount = 3,
            int maxSkillCount = 30,
            int maxExperienceCount = 3)
        {
            Colors = colors;
            TopLineSize = topLineSize;
            NameSize = nameSize;
            Spacing = spacing;
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
        }
    }
}
