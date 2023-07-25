
namespace ResumeBuilder.Shared.Models
{
    public class DocumentTheme
    {
        public ColorModel Colors { get; set; }
        public FontModel Fonts { get; set; }
        public string Bullet { get; set; } = "•";

        public float TopLineSize { get; set; }
        public float NameSize { get; set; }
        public float TitleSize { get; set; }
        public float AboutTextSize { get; set; }
        public float ContactComponentTextSize { get; set; }

        public float Spacing { get; set; }
        public float SkillSpacing { get; set; }
        public float ExperienceSpacing { get; set; }
        public float ProjectSpacing { get; set; }
        public float EducationSpacing { get; set; }

        public float SkillTextSize { get; set; }

        public float ExperienceTitleTextSize { get; set; }
        public float ExperienceCompanyNameTextSize { get; set; }
        public float ExperienceTextSize { get; set; }
        public float ExperienceTimeTextSize { get; set; }

        public float ProjectNameTextSize { get; set; }
        public float ProjectTextSize { get; set; }
        public float ProjectTimeTextSize { get; set; }

        public float EducationSchoolNameTextSize { get; set; }
        public float EducationTextSize { get; set; }
        public float EducationTimeTextSize { get; set; }

        public bool ContactMeTextVisible { get; set; }
        public float ImageSize { get; set; }

        public int SkillsColumnCount { get; set; }
        public int MaxSkillCount { get; set; }
        public int MaxExperienceCount { get; set; }
        public int MaxProjectCount { get; set; }
        public int MaxEducationCount { get; set; }

        public float BorderVerticalThickness { get; set; }
        public float BorderHorizontalThickness { get; set; }

        public DocumentTheme(ColorModel colors,
            FontModel fonts,
            float topLineSize = 50f,
            float nameSize = 40f,
            float titleSize = 20f,
            float aboutTextSize = 14f,

            float spacing = 2f,
            float skillSpacing = 2f,
            float experienceSpacing = 2f,
            float projectSpacing = 2f,

            float contactComponentTextSize = 16f,
            float skillTextSize = 14f,

            float experienceTitleTextSize = 12f,
            float experienceCompanyNameTextSize = 10f,
            float experienceTextSize = 12f,
            float experienceTimeTextSize = 8f,

            float projectNameTextSize = 14f,
            float projectTextSize = 12f,
            float projectTimeTextSize = 8f,

            float educationSchoolNameTextSize = 14f,
            float educationTextSize = 12f,
            float educationTimeTextSize = 8f,

            bool contactMeTextVisible = false,
            float imageSize = 24f,

            int skillsColumnCount = 2,
            int maxSkillCount = 24,
            int maxExperienceCount = 4,
            int maxProjectCount = 4,
            int maxEducationCount = 4,

            float borderVerticalThickness = 1f,
            float borderHorizontalThickness = 1f)
        {
            Colors = colors;
            Fonts = fonts;
            TopLineSize = topLineSize;
            NameSize = nameSize;
            TitleSize = titleSize;
            Spacing = spacing;
            SkillSpacing = skillSpacing;
            ExperienceSpacing = experienceSpacing;
            ProjectSpacing = projectSpacing;
            AboutTextSize = aboutTextSize;
            ContactComponentTextSize = contactComponentTextSize;
            SkillTextSize = skillTextSize;
            ExperienceTitleTextSize = experienceTitleTextSize;
            ExperienceCompanyNameTextSize = experienceCompanyNameTextSize;
            ExperienceTextSize = experienceTextSize;
            ExperienceTimeTextSize = experienceTimeTextSize;
            ProjectNameTextSize = projectNameTextSize;
            ProjectTextSize = projectTextSize;
            ProjectTimeTextSize = projectTimeTextSize;
            EducationSchoolNameTextSize = educationSchoolNameTextSize;
            EducationTextSize = educationTextSize;
            EducationTimeTextSize = educationTimeTextSize;
            ContactMeTextVisible = contactMeTextVisible;
            ImageSize = imageSize;
            SkillsColumnCount = skillsColumnCount;
            MaxSkillCount = maxSkillCount;
            MaxExperienceCount = maxExperienceCount;
            MaxProjectCount = maxProjectCount;
            MaxEducationCount = maxEducationCount;
            BorderVerticalThickness = borderVerticalThickness;
            BorderHorizontalThickness = borderHorizontalThickness;
        }
    }
}
