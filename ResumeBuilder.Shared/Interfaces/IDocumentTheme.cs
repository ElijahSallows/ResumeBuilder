namespace ResumeBuilder.Shared.Interfaces
{
    public interface IDocumentTheme
    {
        public IColorModel Colors { get; set; }
        public IFontModel Fonts { get; set; }
        public string Bullet { get; set; }

        public float TopLineSize { get; set; }
        public float NameSize { get; set; }

        public float Spacing { get; set; }
        public float SkillSpacing { get; set; }
        public float ExperienceSpacing { get; set; }
        public float ProjectSpacing { get; set; }
        public float EducationSpacing { get; set; }

        public float AboutTextSize { get; set; }
        public float ContactComponentTextSize { get; set; }
        public float SkillTextSize { get; set; }
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
    }
}